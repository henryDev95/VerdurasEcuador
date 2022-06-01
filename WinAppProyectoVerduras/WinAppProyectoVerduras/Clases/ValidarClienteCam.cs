using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinAppProyectoVerduras.Clases
{
    class ValidarClienteCam
    {
        public ValidarClienteCam() { }


        public bool validadCedula(string Cedula) // metodo para validar la cedula
        {
            int i = 0, valor = 0, suma = 0;
            int []cedula = new int[10];

            for (i = 0; i < Cedula.Length; i++)
            {
                cedula[i] = Int32.Parse(Cedula[i].ToString());
            }

            int digitoVericador = cedula[9];

            for (i = 0; i < cedula.Length-1; i++)
            {
                if (i % 2 ==0)
                {
                    valor = cedula[i] * 2;
                }
                else
                {
                    valor = cedula[i] * 1;
                }

                if (valor >= 10)
                {
                    valor = valor - 9;
                }
                suma = suma + valor;
            }

            int ValorDecena = (10 - (suma % 10) % 10);

            if (ValorDecena == digitoVericador)
            {
                return true;
            }
            else
            {
                return false;
            }        

        }



        public bool ValidarTelefonos7a10Digitos(string strNumber)
        {
            Regex regex = new Regex("(09)+[0-9]{8,8}$");
            Match match = regex.Match(strNumber);

            if (match.Success)
                return true;
            else
                return false;
        }


        public bool IsValidPassword(string plainText)
        {
            Regex regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");
            Match match = regex.Match(plainText);
            return match.Success;
        }

        public bool ValidarConfirmacionContraseña(string password , string passwordConfir)
        {
            if (password == passwordConfir)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
