using System;
using System.Globalization;

// class Calculadora{
//     static void Main(string[] args) {

//         Console.WriteLine("Digite o primeiro número:");
//         string? primeiroNumero = Console.ReadLine();

//         Console.WriteLine("Digite o segundo número:");
//         string? segundoNumero = Console.ReadLine();

//         float primeiro = float.Parse(primeiroNumero ?? "0", CultureInfo.InvariantCulture);
//         float segundo = float.Parse(segundoNumero ?? "0", CultureInfo.InvariantCulture);

//         Console.WriteLine("Qual operação deseja fazer?");
//         string? operation = Console.ReadLine();

//         float resultado = 0;

//         switch (operation) {
//             case "+":
//                 resultado = primeiro + segundo;
//                 break;
//             case "-":
//                 resultado = primeiro - segundo;
//                 break;
//             case "*":
//                 resultado = primeiro * segundo;
//                 break;
//             case "/":
//                 resultado = primeiro / segundo;
//                 break;
//             default:
//                 Console.WriteLine("Operação inválida");
//                 break;
//         }

//         Console.WriteLine($"Resposta: {resultado}");
//     }
// }

class Task {
    // public List<string> tasks = new();

    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDone { get; set; }
}

class ToDoList {
    // public List<string> tasks = new List<string>();
    // pode ser assim tbm
    public List<string> tasks = new();

    public void AddTask(Task task) {
        string taskAsString = $"{task.Description} - {task.CreatedAt} - {task.DueDate} - {(task.IsDone ? "Done" : "NotDone")} ";
        tasks.Add(taskAsString);
    }

    public void ListTasks() {
        if(tasks.Count == 0) {
            Console.WriteLine("Não há tarefas cadastradas\n");
            return;
        } else {
            Console.WriteLine("\n\n\nTasks:\n");

            foreach (string task in tasks) {
                Console.WriteLine("-------------------------");
                Console.WriteLine(task);
                Console.WriteLine("-------------------------");
            }
        }
    }
}

class Core{
    static void Main(){
        ToDoList toDoList = new();

        bool isRunning = true;

        while(isRunning) {

            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("0 - Sair");

            string? option = Console.ReadLine();

            switch (option) {

                case "1":
                    Console.WriteLine("Digite a descrição da tarefa:");
                    string? description = Console.ReadLine();
                    Console.WriteLine("Digite a data máxima da tarefa:");
                    string? dueDate = Console.ReadLine();

                    Task task = new();
                    {
                        task.Description = description;
                        task.DueDate = DateTime.Parse(dueDate ?? "0", CultureInfo.InvariantCulture);
                        task.CreatedAt = DateTime.Now;
                        task.IsDone = false;
                    }
                    toDoList.AddTask(task);
                    break;

                case "2":
                    toDoList.ListTasks();
                    break;
                default:
                    Console.WriteLine("Até mais!");
                    isRunning = false;
                    break;
            }

        }
    }
}