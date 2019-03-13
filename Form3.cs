using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_hotelier
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.apartament' table. You can move, or remove it, as needed.
            this.apartamentTableAdapter.Fill(this.hotelDataSet.apartament);
            // TODO: This line of code loads data into the 'hotelDataSet.repartitie' table. You can move, or remove it, as needed.
            this.repartitieTableAdapter.Fill(this.hotelDataSet.repartitie);
            // TODO: This line of code loads data into the 'hotelDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.hotelDataSet.client);
            // TODO: This line of code loads data into the 'hotelDataSet.istoric' table. You can move, or remove it, as needed.
        //    this.istoricTableAdapter.Fill(this.hotelDataSet.istoric);
            nrPersoaneComboBox.Items.Add("1");
            nrPersoaneComboBox.Items.Add("2");
            nrPersoaneComboBox.Items.Add("3");
            nrPersoaneComboBox.Items.Add("4");

        }

        
//butonul care adauga
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt=hotelDataSet.client;
            int max=0;
            for (int i = 0; i < dt.Rows.Count; i++)
                if (int.Parse(dt.Rows[i]["id_client"].ToString()) > max)
                    max = int.Parse(dt.Rows[i]["id_client"].ToString());
            

            DataTable dtb = hotelDataSet.repartitie;
            int maxx = 0;
            for (int i = 0; i < dtb.Rows.Count; i++)
                if (int.Parse(dtb.Rows[i]["id_repartitie"].ToString()) > maxx)
                    maxx = int.Parse(dtb.Rows[i]["id_repartitie"].ToString());

            String data2, date1, date2, dataaa;
            data2 = dataInceputDateTimePicker.Text;
            date2 = dataIncheiereDateTimePicker.Text;
            DateTime a1, b1, a2, b2;
            int ok = 1;
            for (int i = 0; i < repartitieDataGridView.Rows.Count; i++)
            {
                if (repartitieDataGridView.Rows[i].Cells[1].ToString() == apartamentTextBox.Text.ToString().Trim())
                {
                    dataaa = repartitieDataGridView.Rows[i].Cells["data_inceput"].ToString();
                    date1 = repartitieDataGridView.Rows[i].Cells["data_sfarsit"].ToString();

                    a1 = Convert.ToDateTime(dataaa);
                    b1 = Convert.ToDateTime(date1);
                    a2 = Convert.ToDateTime(data2);
                    b2 = Convert.ToDateTime(date2);

                    if (a1 < b2 && b1 < a2)
                    {
                        ok = 0;
                        MessageBox.Show("nu exista");
                        break;
                    }
                }
            }
            if (ok == 1)
            {
                clientTableAdapter.InsertQuery(max + 1, numeTextBox.Text, prenumeTextBox.Text, telefonTextBox.Text, emailTextBox.Text);
                clientTableAdapter.Fill(hotelDataSet.client);

                repartitieTableAdapter.InsertQuery(maxx + 1, Convert.ToInt64(apartamentTextBox.Text), max+1, dataInceputDateTimePicker.Text, dataIncheiereDateTimePicker.Text, Convert.ToInt64(pranzTextBox.Text), Convert.ToInt64(micDejunTextBox.Text), Convert.ToInt64(cinaTextBox.Text), Convert.ToInt64(serviciiTextBox.Text), 0, 0);
                repartitieTableAdapter.Fill(hotelDataSet.repartitie);
            }

        }

        private void nrPersoaneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nrPersoaneComboBox.Text.ToString() == "1")
            {
                tipApartamentComboBox.Items.Clear();
                tipApartamentComboBox.Items.Add("single");
            }
            else
                if (nrPersoaneComboBox.Text.ToString() == "2")
                {
                    tipApartamentComboBox.Items.Clear();
                    tipApartamentComboBox.Items.Add("dublu");
                    tipApartamentComboBox.Items.Add("matrimonial");
                   


                }
                else
                    if (nrPersoaneComboBox.Text.ToString() == "3")
                    {
                        tipApartamentComboBox.Items.Clear();
                        tipApartamentComboBox.Items.Add("triplu");
                        tipApartamentComboBox.Items.Add("family");
                       
                    }
                    else
                        if (nrPersoaneComboBox.Text.ToString() == "4")
                        {
                            tipApartamentComboBox.Items.Clear();
                            tipApartamentComboBox.Items.Add("quad");

                        }
        }
        
   
        private void tipApartamentTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        /*
//butonul care sterge
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.repartitieDataGridView.SelectedRows.Count > 0)
                repartitieDataGridView.Rows.RemoveAt(this.repartitieDataGridView.SelectedRows[0].Index);

            if (this.clientDataGridView.SelectedRows.Count > 0)
                clientDataGridView.Rows.RemoveAt(this.clientDataGridView.SelectedRows[0].Index);
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            numeTextBox.Clear();
            prenumeTextBox.Clear();
            telefonTextBox.Clear();
            emailTextBox.Clear();
            tipApartamentComboBox.Items.Clear();
            apartamentTextBox.Clear();
            micDejunTextBox.Clear();
            pranzTextBox.Clear();
            cinaTextBox.Clear();
            serviciiTextBox.Clear();
            pretTotalTextBox.Clear();
        }

        private void pretTotalTextBox_Click(object sender, EventArgs e)
        {
            pretTotalTextBox.Text = (Convert.ToInt32(pretApTextBox.Text) + Convert.ToInt32(micDejunTextBox.Text) * 20 + Convert.ToInt32(pranzTextBox.Text) * 20 + Convert.ToInt32(cinaTextBox.Text) * 20 + Convert.ToInt32(serviciiTextBox.Text) * Convert.ToInt32((dataIncheiereDateTimePicker.Value-dataInceputDateTimePicker.Value).Days)*20).ToString();
        }

        private void tipApartamentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tipApartamentComboBox.Text=="single")
            {               
                pretApTextBox.Text = "180";
            }
            else
                if (tipApartamentComboBox.Text == "dublu")
                    pretApTextBox.Text = "220";
                else
                    if (tipApartamentComboBox.Text == "matrimonial")
                        pretApTextBox.Text = "200";
                    else
                        if (tipApartamentComboBox.Text == "triplu")
                            pretApTextBox.Text = "250";
                        else
                            if (tipApartamentComboBox.Text == "family")
                                pretApTextBox.Text = "270";
                            else
                                if(tipApartamentComboBox.Text=="quad")
                                    pretApTextBox.Text = "300";


        }
        

        


        
    }
}
