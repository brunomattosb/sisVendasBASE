using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas.Sale
{
    public partial class FormBobina : Form
    {
        public FormBobina()
        {
            InitializeComponent();
        }
    }
}

/*
public void inserirCabecalhoBobina()
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
private void inserirProdutoBobina()
{
    try
    {
        Bobina.Items.Add(
        new string('0', 3 - Convert.ToString(itemCoupon).Length) + Convert.ToString(itemCoupon) + "  " +
         new string(' ', 43 - produtoSelecionado.Name.Length) + " " + produtoSelecionado.Name.ToString());

        double total = Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text);
        Bobina.Items.Add(
            new string(' ', 8 - tbAmount.Text.Length) + tbAmount.Text + " " +
            new string(' ', 3 - 2) + produtoSelecionado.Un + " x " +
            new string(' ', 10 - produtoSelecionado.Value.ToString().Length) + "R$ " + produtoSelecionado.Value + " " +
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
private void removerProdutoBobina()
{
    try
    {
        Bobina.Items.Add(
        new string('0', 3 - Convert.ToString(itemCoupon).Length) + Convert.ToString(itemCoupon) + "  " +
         new string(' ', 43 - produtoSelecionado.Name.Length) + " " + produtoSelecionado.Name);

        double total = Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text);
        Bobina.Items.Add(
            new string(' ', 8 - tbAmount.Text.Length) + tbAmount.Text + " " +
            new string(' ', 3 - 2) + produtoSelecionado.Un + " x " +
            new string(' ', 9 - produtoSelecionado.Value.ToString().Length) + "R$ " + "-" + produtoSelecionado.Value + " " +
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
}*/