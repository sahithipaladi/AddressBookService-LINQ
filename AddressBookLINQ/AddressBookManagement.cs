using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    public class AddressBookManagement
    {
        //Creating Data Table
        public readonly DataTable dataTable = new DataTable();

        public AddressBookManagement()
        {
            //Adding Columns to the Data Table
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("City");
            dataTable.Columns.Add("State");
            dataTable.Columns.Add("Zip");
            dataTable.Columns.Add("PhoneNumber");
            dataTable.Columns.Add("Email");


            //Adding Rows to the Data Table
            dataTable.Rows.Add("Sahithi", "V", "n.g.o colony", "kadapa", "Andhra Pradesh", 524003, 9999888867, "sahithi@gmail.com");
            dataTable.Rows.Add("Sivaangi", "p", "Skd colony", "adoni", "Andhra Pradesh", 517102, 8976543210, "sivanngi@gmail.com");
            dataTable.Rows.Add("Mithra", "S", "sk nagar Layout", "Nellore", "Andhra Pradesh", 524003, 9060804050, "mukesh@gmail.com");
            dataTable.Rows.Add("Likitha", "K", "nehrupark Road", "kadapa", "Andhra Praesh", 523108, 8498567909, "likitha@gmail.com");
            dataTable.Rows.Add("Ashwin", "S", "LR Nagar", "Chennai", "Tamil Nadu", 600102, 8367890967, "ashwin@gmail.com");
            dataTable.Rows.Add("Parth", "S", "Kunna Road", "Tadipatri", "Andhra Pradesh", 523108, 6708956789, parth@gmail.com");
            dataTable.Rows.Add("Pari", "M", "Courtroad", "anathapur", "Andhra Pradesh", 600107, 6754894309, "pari@gmail.com");
            dataTable.Rows.Add("Bhasakar", "T", "jublihills", "Hyderabad", "Telegana", 524003,6753428908, "bhasakara@gmail.com");
            dataTable.Rows.Add("Ashangi", "P", "Shanti Nagar", "Ongole", "Andhra Pradesh", 600020, 9484948494, "Ashangi@gmail.com");
            dataTable.Rows.Add("Nithya", "T", "Jaya Nagar", "Kadapa", "Andhra Pradesh", 520010,81814840167,nithy@gmail.com");

            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["PhoneNumber"] };

        }
        //Edit the Data Table 
        public void EditByName()
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString() == "Mithra")
                {
                    dataTable.Rows[i][0] = "Parth";
                }
            }
        }
        //Display the Data Table
        public void Display()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.Write(row[column] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        //Delete a row in Data Table by Name
        public void DeleteByName()
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString() == "Mukesh")
                {
                    dataTable.Rows[i].Delete();
                }
            }
        }
    }
}
