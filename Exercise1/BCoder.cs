using Exercise1.Interfaces;
using System;

namespace Exercise1
{
    public class BCoder: IСoder
    {
        public string Encode(string text)
        {
            string result = "";
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int y = 0; y < Alpabet.alphaRU.Length; y++)
                {
                    if (chars[i] == Alpabet.alphaRU[y])
                    {
                        var rev = Alpabet.alphaRU;
                        Array.Reverse(rev);
                       result += rev[y].ToString();
                        Array.Reverse(rev);
                    }
                }
                for (int x = 0; x < Alpabet.alphaEN.Length; x++)
                {
                    if (chars[i] == Alpabet.alphaEN[x])
                    {
                        var rev = Alpabet.alphaEN;
                        Array.Reverse(rev);
                        result += Alpabet.alphaEN[x].ToString();
                        Array.Reverse(rev);
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
                        var rev = Alpabet.alphaRU;
                        Array.Reverse(rev);
                        result += rev[y].ToString();
                        Array.Reverse(rev);
                    }
                }
                for (int x = 0; x < Alpabet.alphaEN.Length; x++)
                {
                    if (chars[i] == Alpabet.alphaEN[x])
                    {
                        var rev = Alpabet.alphaEN;
                        Array.Reverse(rev);
                        result += rev[x].ToString();
                        Array.Reverse(rev);
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
