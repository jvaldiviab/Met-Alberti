using System;

namespace Met_Alberti
{
    class Alberti
    {
        // Texto Claro
        private string _strMcla;

        public string Mcla
        {
            get { return _strMcla; }
            set { _strMcla = value; }
        }

        // Llave
        private string _strLlave;

        public string Llave
        {
            get { return _strLlave; }
            set { _strLlave = value; }
        }

        // Numero d sustituciones
        private int _intSustituciones;

        public int Sustituciones
        {
            get { return _intSustituciones; }
            set { _intSustituciones = value; }
        }

        // Cantidad de posiciones a mover el disc
        private int _intCantPos;

        public int CantPos
        {
            get { return _intCantPos; }
            set { _intCantPos = value; }
        }

        // Giro
        private string _strGiro;

        public string Giro
        {
            get { return _strGiro; }
            set { _strGiro = value; }
        }

        // Tipo de cifrado
        private string _strTpoCifrado;

        public string TpoCifrado
        {
            get { return _strTpoCifrado; }
            set { _strTpoCifrado = value; }
        }

        // Alf disco externo
        string DiscoFijo = "DX1CGKB8M4RFUIY2L6ÑSHQ5W7EV9NJPZT3AO";
        // Alf disco interno
        string DiscoMovil = "yqva!x0jt@$gzw&eoph%ñdr=cs?m#nfkulib";

        // Metodo para cifrar
        public string Cifrar()
        {
            int IndexDE, IndexDI;
            string DE = "", DI = "", result = "";
            IndexDE = DiscoFijo.IndexOf(Llave[0]);
            IndexDI = DiscoMovil.IndexOf(Llave[1]);

            DE = DiscoFijo.Substring(IndexDE) + DiscoFijo.Substring(0, IndexDE);
            DI = DiscoMovil.Substring(IndexDI) + DiscoMovil.Substring(0, IndexDI);

            if (TpoCifrado == "SIN PARÁMETROS")
            {
                for (int m = 0; m < this.Mcla.Length; m++)
                {
                    for (int i = 0; i < DE.Length; i++)
                    {
                        if (this.Mcla[m] == DE[i])
                        {
                            result += DI[i];
                            break;
                        }
                    }
                }
            }

            if (TpoCifrado == "CON PARÁMETROS")
            {
                for (int m = 0; m < this.Mcla.Length; m++)
                {
                    for (int i = 0; i < DE.Length; i++)
                    {
                        if (this.Mcla[m] == DE[i])
                        {
                            result += DI[i];
                            break;
                        }
                    }

                    if (((m + 1) % this.Sustituciones) == 0)
                    {
                        if (this.Giro == "IZQUIERDA")
                        {
                            DE = DE.Substring(DI.Length - CantPos) + DE.Substring(0, DI.Length - CantPos);
                            result += " ";
                        }
                        if (this.Giro == "DERECHA")
                        {
                            DE = DE.Substring(CantPos) + DE.Substring(0, CantPos);
                            result += " ";
                        }
                    }
                }
            }
            return result;
        }

        public string DESCIFRAR()
        {
            int IndexDE, IndexDI;
            string DE = "", DI = "", result = "";
            IndexDE = DiscoFijo.IndexOf(Llave[0]);
            IndexDI = DiscoMovil.IndexOf(Llave[1]);

            DE = DiscoFijo.Substring(IndexDE) + DiscoFijo.Substring(0, IndexDE);
            DI = DiscoMovil.Substring(IndexDI) + DiscoMovil.Substring(0, IndexDI);

            if (TpoCifrado == "SIN PARÁMETROS")
            {
                for (int m = 0; m < this.Mcla.Length; m++)
                {
                    for (int i = 0; i < DI.Length; i++)
                    {
                        if (this.Mcla[m] == DI[i])
                        {
                            result += DE[i];
                            break;
                        }
                    }
                }
            }

            if (TpoCifrado == "CON PARÁMETROS")
            {
                for (int m = 0; m < this.Mcla.Length; m++)
                {
                    for (int i = 0; i < DE.Length; i++)
                    {
                        if (this.Mcla[m] == DI[i])
                        {
                            result += DE[i];
                            break;
                        }
                    }

                    if (((m + 1) % this.Sustituciones) == 0)
                    {
                        if (this.Giro == "IZQUIERDA")
                        {
                            DE = DE.Substring(DI.Length - CantPos) + DE.Substring(0, DI.Length - CantPos);
                            result += " ";
                        }
                        if (this.Giro == "DERECHA")
                        {
                            DE = DE.Substring(CantPos) + DE.Substring(0, CantPos);
                            result += " ";
                        }
                    }
                }
            }
            return result;
        }
    }

}
