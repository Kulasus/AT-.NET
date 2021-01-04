using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES
{
    public partial class MainForm : Form
    {
        private List<Type> plugins;
        private int widthOffset = 20;
        private int heightOffest = 20;
        public MainForm(List<Type> plugins)
        {
            this.plugins = plugins;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Type plugin in plugins)
            {
                Button newButton = new Button();
                newButton.Text = plugin.Name;
                newButton.Size = new Size(this.Size.Width / 8, this.Size.Height / 8);
                newButton.Location = new Point(widthOffset, heightOffest + (this.Size.Height / 8 * count));
                newButton.Click += (sender, e) => OnButtonClick(sender, e, plugin);
                newButton.Click += (sender, e) => DisplayData(sender, e, plugin);
                Controls.Add(newButton);
                count++;
            }
        }

        private void OnButtonClick(object sender, EventArgs e, Type plugin)
        {
            List<Type> typeInList = new List<Type>();
            typeInList.Add(plugin);
            PluginInvoker.Invoke(typeInList);
        }

        private void DisplayData(object sender, EventArgs e, Type plugin)
        {
            XmlService xmlService = new XmlService(plugin.Name);
            List<Dictionary<string, string>> dataDicts = xmlService.LoadFromXml();
            Dictionary<string, string> lastDataDict = dataDicts[dataDicts.Count - 1];

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(Convert.ToInt64(lastDataDict["timestamp"])).ToLocalTime();

            tbCurrency.Text = lastDataDict["currency"].ToString();
            tbDate.Text = dateTime.ToString();
            tbPrice.Text = lastDataDict["price"].ToString();
        }
    }
}
