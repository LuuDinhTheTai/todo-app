using todo_app.entity;
using todo_app.controller;
using todo_app.service;

namespace todo_app.view
{
    public partial class ChartForm : Form
    {
        private Controller _controller;
        private ChartService _chartService;
        private Tag _tag;
        
        public ChartForm(Controller controller, Tag tag)
        {
            _controller = controller;
            _chartService = controller.ChartService;
            _tag = tag;
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void LoadChartData()
        {

            var (doneCount, undoneCount) = _chartService.GetTodoStatistics(_tag.Id);

            cPie.Series[0].Points.Clear();
 
            if (doneCount > 0)
            {
                cPie.Series[0].Points.AddXY("Đã hoàn thành", doneCount);
                cPie.Series[0].Points[cPie.Series[0].Points.Count - 1].Color = Color.Green;
            }

            if (undoneCount > 0)
            {
                cPie.Series[0].Points.AddXY("Chưa hoàn thành", undoneCount);
                cPie.Series[0].Points[cPie.Series[0].Points.Count - 1].Color = Color.Red;
            }

            if (doneCount == 0 && undoneCount == 0)
            {
                cPie.Series[0].Points.AddXY("không có dữ liệu", 1);
                cPie.Series[0].Points[0].Color = Color.LightGray;
            }

            cPie.Series[0].IsValueShownAsLabel = true;
            cPie.Series[0].LabelFormat = "{0} ({1})";
            cPie.Series[0]["PieLabelStyle"] = "Outside";
            cPie.Series[0]["PieLineColor"] = "Black";
            cPie.Series[0]["PieLineWidth"] = "2";

            cPie.Titles.Clear();
            cPie.Titles.Add($"Tình trạng hoàn thành - {_tag.Name}");
            cPie.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
        }
    }
}
