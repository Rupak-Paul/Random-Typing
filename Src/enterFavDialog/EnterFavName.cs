using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;



namespace Typing_Practice
{
    public partial class EnterFavName : Form
    {

        private SettingDialog settingDialogRef;
        public EnterFavName(SettingDialog settingDialogRef)
        {
            InitializeComponent();

            this.settingDialogRef = settingDialogRef;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterFavTxtBox.Text))
            {
                MessageBox.Show("Enter valid name", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if the json file with the same name exist or not
            string path = SettingDialog.directoryFavourites + "\\" + EnterFavTxtBox.Text + ".json";
            if (File.Exists(path) || EnterFavTxtBox.Text == "setting")
            {
                MessageBox.Show("There is a favourite with same name", "duplicate name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SettingDialog.settingJsonObject tempFav = new SettingDialog.settingJsonObject();
            tempFav.choosedChars = settingDialogRef.pressedCharacters;
            string jsonResult = JsonConvert.SerializeObject(tempFav);

            using (var tw = new StreamWriter(path,true))
            {
                tw.WriteLine(jsonResult.ToString());
                tw.Close();
            }

            settingDialogRef.favourite_box.Items.Add(EnterFavTxtBox.Text);

            this.Visible = false;
        }

    }
}
