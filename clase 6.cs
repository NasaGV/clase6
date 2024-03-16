namespace claseprogra;
class Program {

    static void ejemplo (){

    int  calificaciones;
    calificaciones=new int [] {85,77,68,94,75};
    Console.Writeline([2]);
}

static void Main(string[]args) {
    ejemplo ();
}

static void ejemplo2 () {

    string [] nombres = new string [3];
    nombres [0] = "Juan";
    nombres [1] = "Ana";
    nombres [3] = "Pedro";

    foreach (string nombre in nombres){
        Console.Writeline("Nombre= " +nombre);
    }
}

static void promedios () {
    int [] notas = {80,75,90,95,73,79};
    int promedio;
    int suma; 

    foreach (int nota in notas) {
        suma += nota; 
    }
        promedio = suma/notas.Length;

        Console.Writeline("El promedio de notas es:" + promedio);

}

static void ejemplo3 () {
    int [] calificaciones = {85, 92, 77, 68,94};

    for (int i = 0; i < calificaciones.Length; i++) {
        Console.Writeline($"Calificaciones {i + 1}: {calificaciones[i]}");
    }
}
}




