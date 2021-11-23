using Exercise1.Interfaces;
using System;


namespace Exercise1
{
    public class ACoder : IСoder
    {
        
        public string Encode (string text)
        {
            string result = "";
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int y = 0; y < Alpabet.alphaRU.Length; y++)
                {
                    if (chars[i] == Alpabet.alphaRU[y])
                    {
                        int index = y + 1;
                        if (index >= Alpabet.alphaRU.Length) index = Alpabet.alphaRU.Length - 1;
                        result += Alpabet.alphaRU[index].ToString();
                    }
                }
                for (int x = 0; x < Alpabet.alphaEN.Length; x++)
                {
                    if (chars[i] == Alpabet.alphaEN[x])
                    {
                        result += Alpabet.alphaEN[x+1].ToString();
                    }
                }
                for (int x = 0; x < Alpabet.alphaSimb.Length; x++)
                {
                    if (chars[i] == Alpabet.alphaSimb[x])
                    {
                        result += Alpabet.alphaSimb[x].ToString();
                    }
                }

            }
            return result;
        }

        public string Decode(string text)
        {
            string result = "";
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int y = 0; y < Alpabet.alphaRU.Length; y++)
                {
                    if (chars[i] == Alpabet.alphaRU[y])
                    {
                        int index = y - 1;
                        if (index >= Alpabet.alphaRU.Length) index = Alpabet.alphaRU.Length - 1;
                        result += Alpabet.alphaRU[index].ToString();
                    }
                }
                for (int x = 0; x < Alpabet.alphaEN.Length; x++)
                {
                    if (chars[i] == Alpabet.alphaEN[x])
                    {
                        //int index = x+1;
                        result += Alpabet.alphaEN[x - 1].ToString();
                    }
                }
                for (int x = 0; x < Alpabet.alphaSimb.Length; x++)
                {
                    if (chars[i] == Alpabet.alphaSimb[x])
                    {
                        result += Alpabet.alphaSimb[x].ToString();
                    }
                }
            }
            return result;
        }
    }
}
