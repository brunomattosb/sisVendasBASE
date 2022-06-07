

namespace sisVendas.Functions
{
    class Function
    {
        public static bool isCpfValid(string cpf)
        {
            cpf = replaceAll(cpf);
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
        public static string replaceAll(string str)
        {
            return str.Trim().Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace(")", "").Replace("(", "").Replace(" ", "").Replace("(  )     -", "");
        }
        /*
        public static void labelBlack(Form FormClienteAdicionar)
        {
            foreach (Control lbl in FormClienteAdicionar.Controls)
            {
                if (lbl.GetType() == typeof(GroupBox))
                {
                    lbl.ForeColor = Color.FromArgb(255,0,0) ;
                    //lbl.ForeColor = Color.Gainsboro;
                    //lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }*/

        

    }
}