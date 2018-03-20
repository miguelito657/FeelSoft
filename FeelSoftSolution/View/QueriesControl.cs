﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SocialNetworkConnection;

namespace View
{
    public partial class QueriesControl : UserControl
    {
        public QueriesControl() : base()
        {
            InitializeComponent();
            InitializeDataContainers();

        }

        public void SetMain(WebScrapperViewer main)
        {
            this.main = main;
        }

        private void InitializeDataContainers()
        {
            configurations = new List<IQueryConfiguration>();
        }

             

        private void BtnInitSearchClick(object sender, EventArgs e)
        {
           
            MakeQueryRequest();

        }

        private void MakeQueryRequest()
        {
            main.Search(currentConfiguration);
        }

        private void RdCheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreateQuery_Click(object sender, EventArgs e)
        {
            queryForm = new QueryConfigurationForm();
            DialogResult result = queryForm.ShowDialog();

            if(DialogResult.OK == result)
            {
                currentConfiguration= queryForm.GetQueryConfiguration();
                configurations.Add(currentConfiguration);
                cbxQueries.Items.Add(currentConfiguration);
                cbxQueries.SelectedItem = currentConfiguration;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            object removedObject = cbxQueries.SelectedItem;
            if (removedObject != null)
            {
                cbxQueries.Items.Remove(removedObject);
                MessageBox.Show(removedObject.ToString()+" was removed");
            }
            else
            {
                MessageBox.Show("Seleccione un elemento valido");
            }
        }

        private void CbxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentConfiguration =(IQueryConfiguration) cbxQueries.SelectedItem;
        }
    }
}