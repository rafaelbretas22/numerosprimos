using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosprimos
{
    class calcprimos
    {
        public int limit = 30;
        public List<int> numeros = new List<int>();
        public int currentPosition = 1;
         

        public void initNumbers(int limit) {
            for (int i = 2; i <= limit; i++) {
                
                Console.WriteLine(i.ToString());
                numeros.Add(i);
            }
        }

        public void achareeliminar() {
            currentPosition++;
            if (numeros.Count > currentPosition) { 
            int currentValue = numeros.ElementAt(currentPosition);

                for (int i = currentPosition; i < numeros.Count; i++)
                {
                    Console.WriteLine(numeros.ElementAt(i));
                    if (numeros.ElementAt(i) % currentValue == 0) 
                    {
                        numeros.RemoveAt(i);
                        numeros.Remove(10);
                    }

                }
                Console.ReadKey();
                espera();
                achareeliminar();
            }
        }
        public void numerosparastring() {
            foreach (var item in numeros) { 
                Console.Write(item.ToString() + " ,");
            }
            espera();
        }
        public void espera() {
            Console.ReadKey();
        }
    }
}
