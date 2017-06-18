using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace MyOwnLoginSystem
{
    public partial class FormUserInfoInsert : Form
    {
        public FormUserInfoInsert()
        {
            InitializeComponent();
        }

        private void FormUserInfoInsert_Load(object sender, EventArgs e)
        {
            CmbProvince.Items.Clear();
            CmbCity.Items.Clear();
            CmbDistrict.Items.Clear();

            SQLExecute excute = new SQLExecute();
            DataSet ds = new DataSet();
            int intCount = 0;

            ds = excute.GetProvince();

            intCount = ds.Tables[0].DefaultView.Count;

            for (int i = 0; i < intCount; i++)
            {
                CmbProvince.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        #region 添加市区的信息到Cmb里面

        private void CmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbCity.Items.Clear();
            CmbDistrict.Items.Clear();

            SQLExecute excute = new SQLExecute();
            DataSet ds = new DataSet();
            int intCount = 0;

            ds = excute.GetCityByProvince(CmbProvince.SelectedItem.ToString());
            intCount = ds.Tables[0].DefaultView.Count;

            for (int i = 0; i < intCount; i++)
            {
                CmbCity.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDistrict.Items.Clear();

            SQLExecute excute = new SQLExecute();
            DataSet ds = new DataSet();
            int intCount = 0;

            ds = excute.GetDistrictByProvinceAndCity(CmbProvince.SelectedItem.ToString(),CmbCity.SelectedItem.ToString());
            intCount = ds.Tables[0].DefaultView.Count;

            for (int i = 0; i < intCount; i++)
            {
                CmbDistrict.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        #endregion
    }
}
