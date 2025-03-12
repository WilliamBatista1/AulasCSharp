namespace Listasdearrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numero = new int[5];
            double[] notas = new double [8];
            string[] arrayFrutas = {"banana", "maça", "pera" };

            string nome = "2,20,30,2,5";
            
             Console.WriteLine(nome.Replace(".", " ").Replace("-", " "));

            List<string> fruitlist = new List<string> ();

            fruitlist.Add("banana");
            fruitlist.Add("maça");
            fruitlist.Add("pera");

            //fruitlist.Remove("pera");

                 Console.WriteLine(string.Join(",", fruitlist));

            foreach (string fruit in arrayFrutas) {
                Console.WriteLine(fruitlist);
            }

            fruitlist.ForEach(frutas => Console.WriteLine(frutas));

            Aluno aluno1 = new Aluno("Ana", 77747, "Trasforme-se", "anaglovo.com", "44444545");
            Aluno aluno2 = new Aluno("Natanael", 54547, "Trasforme-se", "natanael.com", "545545461");
            Aluno aluno3 = new Aluno("Victoria", 48484, "Trasforme-se", "victoria.com", "797978448");



                List<Aluno> listAlunos = new List<Aluno>();
                listAlunos.Add(aluno1);
                listAlunos.Add(aluno2);
                listAlunos.Add(aluno3);

            foreach (Aluno aluno in listAlunos) { 
            
                Console.WriteLine($"nome: {aluno.Nome}");
                Console.WriteLine($"matricula: {aluno.Matricula}");
                Console.WriteLine($"curso: {aluno.Curso}");
                Console.WriteLine($"telefone: {aluno.Telefone}");
            

            
            
            
            }






















        }
    }
}