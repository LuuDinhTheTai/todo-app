using ClosedXML.Excel;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using todo_app.controller;

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

        public void ExportFileExcel()
        {
            var tags = _tagService.FindAll();

            if (tags == null || !tags.Any())
            {
                MessageBox.Show("Không có tag nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Chọn vị trí lưu file Excel",
                FileName = $"Todo_By_Tags_{DateTime.Now:yyyyMMdd}.xlsx"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Todos by Tag");
                        int currentRow = 1;

                        foreach (var tag in tags)
                        {
                            // --- Tiêu đề Tag ---
                            worksheet.Cell(currentRow, 1).Value = $"Tag: {tag.Name}";
                            worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                            worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
                            currentRow++;

                            // --- Header cột ---
                            worksheet.Cell(currentRow, 1).Value = "Nội dung công việc";
                            worksheet.Cell(currentRow, 2).Value = "Trạng thái";

                            var headerRange = worksheet.Range(currentRow, 1, currentRow, 2);
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                            headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            currentRow++;

                            // --- Dữ liệu Todo ---
                            var todos = _todoService.FindByTagId(tag.Id);

                            if (todos == null || !todos.Any())
                            {
                                worksheet.Cell(currentRow, 1).Value = "(Không có công việc nào)";
                                worksheet.Range(currentRow, 1, currentRow, 2).Merge();
                                worksheet.Cell(currentRow, 1).Style.Font.Italic = true;
                                currentRow += 2;
                                continue;
                            }

                            foreach (var todo in todos)
                            {
                                worksheet.Cell(currentRow, 1).Value = todo.Content;
                                worksheet.Cell(currentRow, 2).Value = todo.IsDone ? "✅ Hoàn thành" : "❌ Chưa làm";
                                currentRow++;
                            }

                            currentRow += 2; // cách 1 dòng giữa các Tag
                        }

                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(sfd.FileName);

                        MessageBox.Show("Xuất file Excel thành công!\nĐã lưu tại: " + sfd.FileName,
                                        "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
            }
        }
    }
}
