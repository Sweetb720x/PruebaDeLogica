// See https://aka.ms/new-console-template for more information

List<int> lista = new List<int>();
List<int> lista2 = new List<int>();
lista.Add(1);
lista.Add(2);
lista.Add(3);
lista.Add(4);
lista.Add(5);
lista.Add(6);
lista.Add(7);
lista.Add(8);
lista.Add(9);
lista.Add(10);

lista2.Add(1);
lista2.Add(2);
lista2.Add(3);
lista2.Add(4);
lista2.Add(5);
lista2.Add(6);
lista2.Add(7);
lista2.Add(9);
lista2.Add(10);

int Hallar()
{
    foreach (int li in lista)
    {
        foreach (int li2 in lista2)
        {
            if (lista2.Contains(li) == false)
            {
                return li;
            }
        }
    }
    return 0;
}


Console.WriteLine(Hallar());


