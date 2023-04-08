using Sunny.UI;
using System.Reflection;

namespace 控制中心
{
    public partial class Form1 : UIHeaderAsideMainFrame
    {
        public Form1()
        {
            InitializeComponent();
            init_Main_Aside();
        }
        private void init_Main_Aside()
        {
            //// 页面1
            //int pageIndex = 1000;
            //Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            //Header.SetNodeSymbol(Header.Nodes[0], 61451);
            //TreeNode parent = Aside.CreateNode("模型", 61451, 24, pageIndex);

            //// 页面2
            //pageIndex = 2000;
            //Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            //Header.SetNodeSymbol(Header.Nodes[1], 61818);
            //parent = Aside.CreateNode("绘图", 61818, 24, pageIndex);


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}