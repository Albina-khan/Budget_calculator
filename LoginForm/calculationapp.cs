using LoginForm.database;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LoginForm
{
	public partial class calculationapp : Form
	{
		public calculationapp()
		{

			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			decimal netamount = amount.Value;
			string item = type.Text.ToString();
			decimal ship = shipment.Value;
			decimal itemDuty = duty.Value;
			decimal result = total.Value;
			decimal areaRent = area.Value;
			decimal trans = transport.Value;
			decimal quantity = qty.Value;
			decimal perProfit = (profit.Value / 100);


			if (netamount! > 0 || ship! > 0 || itemDuty! > 0 || areaRent! > 0 || trans! > 0 || quantity! > 0)
			{
				total.Value = netamount + ship + itemDuty + areaRent + trans;
				cost.Value = (total.Value / quantity) + perProfit;

			}
			else
			{
				MessageBox.Show("Null Values not acceptable.");
			}

		}

		private void save_Click(object sender, EventArgs e)
		{

			decimal netamount = amount.Value;
			string item = type.Text.ToString();
			decimal ship = shipment.Value;
			decimal itemDuty = duty.Value;
			decimal result = total.Value;
			decimal areaRent = area.Value;
			decimal trans = transport.Value;

			if (DbContextClass.OpenConnection() == true)
			{
				string cap = "Are you Sure you wants to save a record !";
				string cap2 = "form Closing";
				var resultss = MessageBox.Show(cap, cap2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (resultss == DialogResult.Yes)
				{
					string query = "insert into Budget(name , amount , shipment , duty , area_rent , transport_rent , date , total)" +
					"values('" + item + "' , '" + netamount + "' , '" + ship + "' , '" + itemDuty + "' , '" + areaRent + "' , '" + trans + "' , '" + this.dateTimePicker1.Value + "' , '" + this.total.Value + "' )";
					SqlCommand cmd = new SqlCommand(query, DbContextClass.connection);
					cmd.ExecuteNonQuery();

					MessageBox.Show("saved");
				}
			}
		}

	}
}
