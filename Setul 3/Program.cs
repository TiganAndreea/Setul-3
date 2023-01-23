using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3
{
    internal class Program
    {

        static void p1()
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int suma = 0;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n; i++)
            {
                suma += v[i];
            }
            Console.WriteLine(suma);
        }
        static void p2()
        {
            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i =0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine(i);
                    ok = true;
                    break;
                }

                if (!ok)
                    Console.WriteLine("-1");
            }
        }
        static void p3()
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int minim = v[0];
            int maxim = v[0];
            int[] pozminim = new int[n];
            int[] pozmaxim = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (v[i] >= maxim)
                    maxim = v[i];

                if (v[i] <= minim)
                    minim = v[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == maxim)
                    pozmaxim[i]++;
                if (v[i] == minim)
                    pozminim[i]++;
            }
            Console.Write("Cel mai mic element al vectorului se afla pe poz: ");
            for (int a = 0; a < n; a++)
            {
                if (pozminim[a] != 0)
                    Console.Write(a + " ");
            }
            Console.WriteLine();

            Console.Write("Cel mai mare element al vectorului se afla pe poz: ");
            for (int b = 0; b < n; b++)
            {
                if (pozmaxim[b] != 0)
                    Console.Write(b + " ");
            }
        }
        static void p4()
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
        }
        static void p5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.
        }
        static void p6()
        {
            //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
        }
        static void p7()
        {
            //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        }
        static void p8()
        {
            //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
        }
        static void p9()
        {
            //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        }
        static void p10()
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        }
        static void p11()
        {
            //Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
            int n = int.Parse(Console.ReadLine());
            bool[] v = new bool[n];
            int idx = 2;
            do
            {
                int k = 1;
                while (idx * k < n)
                {
                    v[idx * k] = true;
                    k++;
                }
                while (v[idx]) idx++;
                Console.Write(idx + " ");
            }
            while (idx < n - 1);
        }
        static void p12()
        {
            //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        }
        static void p13()
        {
            //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
        }
        static void p14()
        {
            //Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
        }
        static void p15()
        {
            //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        }
        static void p16()
        {
            //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        }
        static void p17()
        {
            //Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int i = 0;
            int lungime = 0;
            int c, r;
            c = n / b;
            int[] v = new int[n];
            while (c > 0)
            {
                r = n % b;
                v[i++] = r;
                lungime++;
                n = c;
                c = n / b;
                if (c == 0)
                {
                    r = n % b;
                    v[i++] = r;
                    lungime++;
                }
            }
            for (i = lungime; i >= 0; i--)
                Console.Write(v[i] + " ");

        }
            static double val(double[] P, double x)
            {
                double suma = 0;
                for (int i = 0; i < P.Length; i++)
                    suma += P[i] * Math.Pow(x, i);
                return suma;
            }
        static void p18()
        {
            //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
            TextReader load = new StreamReader(@"..\..\polinom.txt");

            int n = int.Parse(load.ReadLine());
            double[] P = new double[n];
            string[] t = load.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                P[i] = double.Parse(t[i]);
            }
            double x = double.Parse(load.ReadLine());
            Console.Write(val(P, x).ToString());
            Console.ReadKey();
        }
        static void p19()
        {
            //Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).
            TextReader load = new StreamReader(@"..\..\vectori.txt");

            string[] t1 = load.ReadLine().Split(' ');
            int[] s = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                s[i] = int.Parse(t1[i]);

            string[] t2 = load.ReadLine().Split(' ');
            int[] p = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                p[i] = int.Parse(t2[i]);
            int nr = 0;
            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                if (s[i] == p[0])
                {
                    bool ok = true;
                    for (int j = 1; j < p.Length; j++)
                        if (p[j] != s[i + j])
                            ok = false;
                    if (ok) nr++;
                }
            }
            Console.Write(nr);
        }
        static void p20()
        {
            //Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
            TextReader load = new StreamReader(@"..\..\margele.txt");

            string[] t1 = load.ReadLine().Split(' ');
            int[] s1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                s1[i] = int.Parse(t1[i]);

            string[] t2 = load.ReadLine().Split(' ');
            int[] s2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                s2[i] = int.Parse(t2[i]);
            int max = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                int s = 0;
                for (int j = 0; j < s2.Length; j++)
                    if (s1[(i + j) % s1.Length] == s2[j])
                        s++;
                if (s > max) max = s;
            }
            Console.Write(max);
            Console.ReadKey();
        }
        static int check(int[] s1, int[] s2)
        {
            int min = s1.Length;
            if (s2.Length < min) min = s2.Length;
            for (int i = 0; i < min; i++)
                if (s1[i] != s2[i])
                {
                    if (s1[i] > s2[i])
                        return 1;
                    else
                        return -1;
                }
            if (s1.Length == min && s2.Length == min)
                return 0;
            if (s1.Length == min)
                return -1;
            else
            if (s2.Length == min)
                return 1;
            else
                return 0;
        }
        static void p21()
        {
            //Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
            string[] t1 = Console.ReadLine().Split(' ');
            int[] s1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                s1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] s2 = new int[t1.Length];
            for (int i = 0; i < t2.Length; i++)
                s2[i] = int.Parse(t2[i]);
            Console.Write(check(s1, s2));

        }
        static void p22()
        {
            //Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int lungime = t1.Length + t2.Length;
            int[] N = new int[lungime];
            int[] U = new int[lungime];
            int[] D1 = new int[lungime];
            int[] D2 = new int[lungime];
            int a = 0, nl = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                for (int j = 0; j < t2.Length; j++)
                    if (v1[i] == v2[j])
                    {
                        N[a++] = v1[i];
                        nl++;
                    }
            }
            for (a = 0; a < nl; a++)
                Console.Write(N[a] + " ");
            Console.WriteLine();

            int b = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                U[b++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                U[b++] = v2[i];
            }
            for (b = 0; b < lungime; b++)
                Console.Write(U[b] + " ");
            Console.WriteLine();

            int c = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                bool d1 = true;
                for (int j = 0; j < t2.Length; j++)
                {

                    if (v1[i] == v2[j])
                    {
                        d1 = false;
                    }

                }
                if (d1)
                {
                    D1[c] = v1[i];
                    c++;
                }
            }
            for (int i = 0; i < c; i++)
                Console.Write(D1[i] + " ");
            Console.WriteLine();

            int d = 0;
            for (int i = 0; i < t2.Length; i++)
            {
                bool d2 = true;
                for (int j = 0; j < t1.Length; j++)
                {

                    if (v2[i] == v1[j])
                    {
                        d2 = false;
                    }
                }
                if (d2)

                    D2[d++] = v2[i];
            }
            for (int i = 0; i < d; i++)
                Console.Write(D2[i] + " ");

        }
        static void p23()
        {
            //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int lungime = t1.Length + t2.Length;
            int[] N = new int[lungime];
            int[] U = new int[lungime];
            int[] D1 = new int[lungime];
            int[] D2 = new int[lungime];
            int a = 0, nl = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                for (int j = 0; j < t2.Length; j++)
                    if (v1[i] == v2[j])
                    {
                        N[a++] = v1[i];
                        nl++;
                    }
            }
            for (a = 0; a < nl; a++)
                Console.Write(N[a] + " ");
            Console.WriteLine();

            int b = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                U[b++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                U[b++] = v2[i];
            }
            for (b = 0; b < lungime; b++)
                Console.Write(U[b] + " ");
            Console.WriteLine();

            int c = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                bool d1 = true;
                for (int j = 0; j < t2.Length; j++)
                {

                    if (v1[i] == v2[j])
                    {
                        d1 = false;
                    }

                }
                if (d1)
                {
                    D1[c] = v1[i];
                    c++;
                }
            }
            for (int i = 0; i < c; i++)
                Console.Write(D1[i] + " ");
            Console.WriteLine();

            int d = 0;
            for (int i = 0; i < t2.Length; i++)
            {
                bool d2 = true;
                for (int j = 0; j < t1.Length; j++)
                {

                    if (v2[i] == v1[j])
                    {
                        d2 = false;
                    }
                }
                if (d2)

                    D2[d++] = v2[i];
            }
            for (int i = 0; i < d; i++)
                Console.Write(D2[i] + " ");
        }
        static void p24()
        {
            //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar). 
           
        }
        static void p25()
        {
            //(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int[] F = new int[t1.Length + t2.Length];
            int f = 0;

            for (int i = 0; i < t1.Length; i++)
            {
                F[f++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                F[f++] = v2[i];
            }
            int key, j;
            for (int i = 1; i < t1.Length + t2.Length; i++)
            {
                key = F[i];
                j = i - 1;
                while (j >= 0 && F[j] > key)
                {
                    F[j + 1] = F[j];
                    j--;
                }
                F[j + 1] = key;
            }
            for (int i = 0; i < t1.Length + t2.Length; i++)
                Console.Write(F[i] + " ");
        }

        static int[] QuickSort(int[] v, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = v[left];
            while (i <= j)
            {
                while (v[i] < pivot)
                {
                    i++;
                }

                while (v[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = v[i];
                    v[i] = v[j];
                    v[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(v, left, j);
            if (i < right)
                QuickSort(v, i, right);
            return v;

        }
        static void p26()
        {
            //Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.
        }
        static void p27()
        {
            //Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.
        }
        static void p28()
        {
            //Quicksort. Sortati un vector folosind metoda QuickSort.
        }
        static void p29()
        {
            //MergeSort. Sortati un vector folosind metoda MergeSort.
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            Sort(v, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
         }
        static void p30()
        {
            //Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
        }
        static void p31()
        {
            //(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
            }
            if (nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
                p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
                p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
                p11();
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
                p12();
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
                p13();
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
                p14();
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
                p15();
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
                p16();
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
                p17();
            }
            if(nrp == 18)
            {
                Console.WriteLine("Problema " + nrp);
                p18();
            }
            if (nrp == 19)
            {
                Console.WriteLine("Problema " + nrp);
                p19();
            }
            if (nrp == 20)
            {
                Console.WriteLine("Problema " + nrp);
                p20();
            }
            if (nrp == 21)
            {
                Console.WriteLine("Problema " + nrp);
                p21();
            }
            if (nrp == 22)
            {
                Console.WriteLine("Problema " + nrp);
                p22();
            }
            if (nrp == 23)
            {
                Console.WriteLine("Problema " + nrp);
                p23();
            }
            if (nrp == 24)
            {
                Console.WriteLine("Problema " + nrp);
                p24();
            }
            if (nrp == 25)
            {
                Console.WriteLine("Problema " + nrp);
                p25();
            }
            if (nrp == 26)
            {
                Console.WriteLine("Problema " + nrp);
                p26();
            }
            if (nrp == 27)
            {
                Console.WriteLine("Problema " + nrp);
                p27();
            }
            if (nrp == 28)
            {
                Console.WriteLine("Problema " + nrp);
                p28();
            }
            if (nrp == 29)
            {
                Console.WriteLine("Problema " + nrp);
                p18();
            }
            if (nrp == 29)
            {
                Console.WriteLine("Problema " + nrp);
                p29();
            }
            if (nrp == 30)
            {
                Console.WriteLine("Problema " + nrp);
                p30();
            }
            if (nrp == 31)
            {
                Console.WriteLine("Problema " + nrp);
                p31();
            }
            Console.ReadKey();
        }
    }
}
