 private void btnOffsetAdd_Click(object sender, EventArgs e)
        {
            if(tbOffsetValue.Text.Count()>0)
            {
                string text = tbOffsetValue.Text.Replace("R$", "");
                double value = double.Parse(text);
                if (totalOffset + value <= totalSale)
                {
                    totalOffset = totalOffset + value;
                    lbListOffsetValue.Items.Add(tbOffsetValue.Text);

                    tbTotalOffset.Text = "R$: " + totalOffset.ToString();
                    tbSubtotalOffset.Text = "R$: " + (totalSale - totalOffset) + "";

                    tbOffsetValue.Text = "";
                    tbOffsetValue.Focus();
                }
                else
                {
                    Function.Alert("Alerta!", "Valor a ser pago maior que saldo devedor.", popupClient.enmType.Warning);
                }
            }
        }

        private void btnOffsetRemove_Click(object sender, EventArgs e)
        {
            if (tbOffsetValue.Text.Count() > 0)
            {
                string text = tbOffsetValue.Text.Replace("R$", "");
                double value = double.Parse(text);

                if (value <= totalOffset) 
                {
                    totalOffset = totalOffset - value;
                    lbListOffsetValue.Items.Add("-"+tbOffsetValue.Text);

                    tbTotalOffset.Text = "R$: " + totalOffset.ToString();
                    tbSubtotalOffset.Text = "R$: " + (totalSale - totalOffset) + "";

                    tbOffsetValue.Text = "";
                    tbOffsetValue.Focus();
                }
                else
                {
                    Function.Alert("Alerta!", "Valor a ser pago maior que saldo devedor.", popupClient.enmType.Warning);
                }
            }
        }

        private void tbOffsetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbOffsetValue_Leave(object sender, EventArgs e)
        {
            
            string text = tbOffsetValue.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
                tbOffsetValue.Text = String.Format("{0:c}", res);
            else
            {
                tbOffsetValue.Text = "";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
            }
        }
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
        #region Init
        public void initDataGridView()
        {
            dtProducts.TableName = "products";
            dtProducts.Columns.Add("name");
            dtProducts.Columns.Add("amount", typeof(double));
            dtProducts.Columns.Add("un");
            dtProducts.Columns.Add("valueun", typeof(double));
            dtProducts.Columns.Add("valuetotal", typeof(double));

            dtProducts.PrimaryKey = new DataColumn[] { dtProducts.Columns["name"] };
            dgvProducts.DataSource = dtProducts;
        }
        public void cleanForm()
        {
            /*mtbCpf.Text =
            mtbRgIe.Text =
            tbName.Text =
            tbFantasyName.Text =
            tbAddres.Text =
            tbCity.Text =
            tbDistrict.Text =
            mtbCep.Text =
            cbbEstado.Text =
            mtbDtNasc.Text =
            mtbRgIe.Text =
            tbEmail.Text =
            mtbTelephone.Text =
            tbCod.Text = "";
            cbbEstado.SelectedIndex = -1;
            cbbSex.SelectedIndex = -1;*/
        }
        #endregion

        #region Print Coil
        public void insertHeaderCoil()
        {
            try
            {
                Bobina.Items.Add(new string('-', 51));
                Bobina.Items.Add("               **     NFC-e     **               ");
                Bobina.Items.Add(new string('-', 51));
                Bobina.Items.Add("ITEM Codigo         Descricao                   ");
                Bobina.Items.Add("QTD.     UN      VL.UNIT.(R$)       VL.ITEM(R$)");
                Bobina.Items.Add(new string('-', 51));
            }
            catch (Exception eError)
            {
                //Log.write(eError.ToString());
            }
        }
        private void insertProductCoil()
        {
            try
            {
                Bobina.Items.Add(
                new string('0', 3 - Convert.ToString(itemCoupon).Length) + Convert.ToString(itemCoupon) + "  " +
                 new string(' ', 43 - productSelected["prod_name"].ToString().Length) + " " + productSelected["prod_name"].ToString());

                double total = Convert.ToDouble(productSelected["prod_value"]) * Convert.ToDouble(tbAmount.Text);
                Bobina.Items.Add(
                    new string(' ', 8 - tbAmount.Text.Length) + tbAmount.Text + " " +
                    new string(' ', 3 - 2) + "UN" + " x " +
                    new string(' ', 10 - productSelected["prod_value"].ToString().Length) + "R$ " + productSelected["prod_value"] + " " +
                    new string(' ', 5) + new string(' ', 11 - total.ToString().Length) + "R$ " + total
                    );
            }
            catch (Exception eError)
            {
                //Log.write(eError.ToString());
            }

            //sempre atualiza a seleção no ultimo index;
            Bobina.SelectedIndex = Bobina.Items.Count - 1;
            //contador
            itemCoupon++;

            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }
        private void removeProductCoil()
        {
            //Bobina.Items.Add("QTD.     UN      VL.UNIT.(R$)       VL.ITEM(R$)");
            //49


            try
            {
                Bobina.Items.Add(
                new string('0', 3 - Convert.ToString(itemCoupon).Length) + Convert.ToString(itemCoupon) + "  " +
                 new string(' ', 43 - productSelected["prod_name"].ToString().Length) + " " + productSelected["prod_name"].ToString());

                double total = Convert.ToDouble(productSelected["prod_value"]) * Convert.ToDouble(tbAmount.Text);
                Bobina.Items.Add(
                    new string(' ', 8 - tbAmount.Text.Length) + tbAmount.Text + " " +
                    new string(' ', 3 - 2) + "UN" + " x " +
                    new string(' ', 9 - productSelected["prod_value"].ToString().Length) + "R$ " +"-" +productSelected["prod_value"] + " " +
                    new string(' ', 5) + new string(' ', 10 - total.ToString().Length) + "-" + "R$ " + total
                    );
            }
            catch (Exception eError)
            {
                //Log.write(eError.ToString());
            }

            Bobina.SelectedIndex = Bobina.Items.Count - 1;

            itemCoupon++;
            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }
        #endregion

        #region OpenForm
        private void openFormFinalizeSale()
        {
            FormTypeOfPayment f = new FormTypeOfPayment();
            f.ShowDialog();


            /*productSelected = f.returnClient();

            if (productSelected != null)
            {
                fillProduct();
            }
            tbNameClient.Focus();*/
        }



        #endregion

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    openFormClient();
                    break;
                case Keys.F2:
                    openFormProduct();
                    break;
                case Keys.F9:
                    openFormThing();
                    break;
                case Keys.F12:
                    openFormFinalizeSale();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Print DataTable
        private void addToDataTable()
        {

            string prod_name = productSelected["prod_name"].ToString();
            DataRow row = dtProducts.Rows.Find(prod_name);
            int index = dtProducts.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                DataRow linha = dtProducts.NewRow();

                linha["name"] = productSelected["prod_name"];
                linha["amount"] = Convert.ToDouble(tbAmount.Text);
                linha["valueun"] = productSelected["prod_value"];
                linha["valuetotal"] = Convert.ToDouble(productSelected["prod_value"]) * Convert.ToDouble(tbAmount.Text);
                linha["un"] = "UN";

                dtProducts.Rows.Add(linha);
                dgvProducts.DataSource = dtProducts;
            }   
            else //caso ja exista no dt
            {
                dtProducts.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) + Convert.ToDouble(tbAmount.Text);
                dtProducts.Rows[index]["valueTotal"] = Convert.ToDouble(dtProducts.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"]);
            }
            totalSale = totalSale + (Convert.ToDouble(productSelected["prod_value"]) * Convert.ToDouble(tbAmount.Text));
            lblTotal.Text = "R$ " + totalSale;
        }

        private void removeToDataTable()
        {

            string prod_name = productSelected["prod_name"].ToString();
            DataRow row = dtProducts.Rows.Find(prod_name);
            int index = dtProducts.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                Function.Alert("Atenção!", "Não é possivel remover um produto que não está na compra!", popupClient.enmType.Warning);
            }
            else //caso ja exista no dt
            {
                
                if (Convert.ToDouble(tbAmount.Text) <= Convert.ToDouble(row["amount"]))
                {
                    removeProductCoil();
                    dtProducts.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) - Convert.ToDouble(tbAmount.Text);
                    dtProducts.Rows[index]["valueTotal"] = Convert.ToDouble(row["valueun"]) * Convert.ToDouble(dtProducts.Rows[index]["amount"]);

                    totalSale = totalSale - (Convert.ToDouble(row["valueun"]) * Convert.ToDouble(tbAmount.Text));
                    lblTotal.Text = "R$ " + totalSale;

                    //caso quantidade seja zero
                    if (Convert.ToDouble(dtProducts.Rows[index]["amount"]) == 0)
                    {
                        dtProducts.Rows[index].Delete();
                    }
                }
                else
                    Function.Alert("Atenção!", "Não é possivel deixar a quantidade negativa!", popupClient.enmType.Warning);
            }
            
        }
        #endregion


        #region Utilitários

        private void timer_sale_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime.Now.ToString("dd/MM/yyyy");
        }
        #endregion

        #region product
        private void tbCodProduct_Leave(object sender, EventArgs e)
        {
            if(isExistsProduct())
                fillProduct();
        }
        private bool isExistsProduct()
        {
            string cod = tbCodProduct.Text;

            if (cod.Count() != 0)
            {
                DataTable dt = controlProduct.searthProductByCod(cod);

                if (dt.Rows.Count == 0)
                {
                    Function.Alert("Atenção!", "Código de produto inexistente!", popupClient.enmType.Warning);
                    tbCodProduct.Text = tbNameProduct.Text = "";
                    tbCodProduct.Focus();
                    productSelected = null;
                    return false;
                }
                else
                {
                    productSelected = dt.Rows[0];
                    return true;
                }
            }
            productSelected = null;
            return false;
        }
        private void fillProduct( )
        {
            tbNameProduct.Text = productSelected["prod_name"].ToString();
            tbCodProduct.Text = productSelected["prod_id"].ToString();
        }
        public void openFormProduct()
        {
            FormSearthProduct f = new FormSearthProduct();
            f.ShowDialog();


            productSelected = f.returnClient();

            if (productSelected != null)
            {
                fillProduct();
            }
            tbNameClient.Focus();
        }
        public void openFormThing()
        {
            FormThing f = new FormThing();
            f.ShowDialog();
        }

        private void tbCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (isExistsProduct())
                {
                    addProduct();

                }
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) //ENTER
            {
                addProduct();
            }
            if (e.KeyChar == (char)45) // [MENOS]
            {
                removeProduct();
            }
        }

        private void addProduct()
        {
            if(tbAmount.Text.Count() > 0)
            {
                if (productSelected != null && Convert.ToDouble(tbAmount.Text) != 0)
                {
                    insertProductCoil();
                    addToDataTable();
                }
            }
            else
            {
                Function.Alert("Atenção!", "Quantidade inválida!", popupClient.enmType.Warning);
            }
            
        }
        private void removeProduct()
        {
            if (productSelected != null && Convert.ToDouble(tbAmount.Text) != 0)
            {
                removeToDataTable();
                
            }

        }
        #endregion

        #region Region Client
        private void mtbCpfClient_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpfClient.Text).Length == 0)
                mtbCpfClient.Select(0, 0);
        }
        public void openFormClient()
        {
            FormSearthClient f = new FormSearthClient();
            f.ShowDialog();

            DataRow drClient;

            
            drClient = f.returnClient();

            if (drClient != null)
            {
                tbNameClient.Text = drClient["cli_name"].ToString();
                mtbCpfClient.Text = drClient["cli_cpf_cnpj"].ToString();
                lblWarningCpf.Visible = false;
            }
            tbNameClient.Focus();
        }
        private void mtbCpfClient_Leave(object sender, EventArgs e)
        {
            isExistsClient();
        }

        private bool isExistsClient()
        {
            
        }
        #endregion
