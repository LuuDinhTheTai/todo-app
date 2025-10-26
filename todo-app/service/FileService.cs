using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using todo_app.controller;
using todo_app.exception;
using Excel = Microsoft.Office.Interop.Excel;

namespace todo_app.service
{
    public class FileService
    {
        private readonly TagService _tagService;
        private readonly TodoService _todoService;

        public FileService(Controller controller)
        {
            _tagService = controller.TagService;
            _todoService = controller.TodoService;
        }

        public bool ExportFileExcel(string filePath)
        {
            var tags = _tagService.FindAll();

            if (tags == null || !tags.Any())
            {
                throw new AppException("Không có tag nào để xuất!");
            }
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Add();
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Todos by Tag";

            int currentRow = 1;

            foreach (var tag in tags)
            {
                //Tiêu đề Tag
                worksheet.Cells[currentRow, 1] = $"Tag: {tag.Name}";
                Excel.Range tagTitle = worksheet.Range[worksheet.Cells[currentRow, 1], worksheet.Cells[currentRow, 1]];
                tagTitle.Font.Bold = true;
                tagTitle.Font.Size = 14;
                currentRow++;

                //Header
                worksheet.Cells[currentRow, 1] = "Nội dung công việc";
                worksheet.Cells[currentRow, 2] = "Trạng thái";

                Excel.Range headerRange = worksheet.Range[worksheet.Cells[currentRow, 1], worksheet.Cells[currentRow, 2]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                currentRow++;

                //Dữ liệu Todo
                var todos = _todoService.FindByTagId(tag.Id);

                if (todos == null || !todos.Any())
                {
                    worksheet.Cells[currentRow, 1] = "(Không có công việc nào)";
                    Excel.Range emptyRange = worksheet.Range[worksheet.Cells[currentRow, 1], worksheet.Cells[currentRow, 2]];
                    emptyRange.Merge();
                    emptyRange.Font.Italic = true;
                    currentRow += 2;
                    continue;
                }

                foreach (var todo in todos)
                {
                    worksheet.Cells[currentRow, 1] = todo.Content;
                    worksheet.Cells[currentRow, 2] = todo.IsDone ? "Hoàn thành" : "Chưa làm";
                    currentRow++;
                }

                currentRow += 2;
            }

            //Căn chỉnh cột
            worksheet.Columns.AutoFit();

            //Lưu file
            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();

            if (worksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            worksheet = null;
            workbook = null;
            excelApp = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            return true;
        }
    }
}

