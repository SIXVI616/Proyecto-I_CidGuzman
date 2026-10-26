namespace Proyecto_I_CidGuzman
{
    public partial class Juego : Form
    {
        // Inicializacion de variables globales
        float n1 = 0, n2 = 0, resultado = 0;
        int op = 0, cantJugadores = 1, turno = 0;
        char operador = ' ';

        // Inicializacion de arreglos
        string[] nombres = new string[2]; // Aca se guarda el nombre del jugador paralelo
        int[,] jugadores = new int[2, 5]; // Aca se guardsn los datos del jugador (en las columnas)

        // Arreglos paralelos para guardar el historial de datos
        string[] historialNombres = new string[50];
        int[] historialPuntos = new int[50];
        int cantResultados = 0; // Variable que sirve como punto de comparacion para no sobrepasar los limites de los arreglos

        public Juego()
        {
            InitializeComponent();
        }

        // Creacion de la matriz del Jugador
        private void IniciarJugadores()
        {
            for (int i = 0; i < cantJugadores; i++)
            {
                jugadores[i, 0] = 0; // Aca se guardan los puntos
                jugadores[i, 1] = 0; // Aca se guardan los aciertos
                jugadores[i, 2] = 0; // Aca se guardan los errores
                jugadores[i, 3] = 3; // Aca se guardan las vidas
                jugadores[i, 4] = 1; // Aca se guarda el valor de la dificultad
            }

            turno = 0; // Indica el turno del jugador (luego lo utilizo como jugadores[turno...] para alternar al jugador)
        }

        // Funcion que randomiza operaciones basado en el valor de la dificultad del jugador
        private void OperacionAleatoria()
        {

            int dificultad = jugadores[turno, 4];

            if (dificultad == 1) // Facil. Aca solo salen numeros del 1-10 con sumas y restas
            {

                n1 = Random.Shared.Next(1, 11);
                n2 = Random.Shared.Next(1, 11);
                op = Random.Shared.Next(1, 3);

                switch (op)
                {
                    case 1:
                        operador = '+';
                        resultado = n1 + n2;
                        break;
                    case 2:
                        operador = '-';
                        resultado = n1 - n2;
                        break;
                    default:
                        Console.WriteLine("Operador no valido.");
                        break;
                }
            }
            else if (dificultad == 2) // Medio. Aca solo salen numeros del 1-100 y se agrega la multiplicacion
            {

                n1 = Random.Shared.Next(1, 101);
                n2 = Random.Shared.Next(1, 101);
                op = Random.Shared.Next(1, 4);

                switch (op)
                {
                    case 1:
                        operador = '+';
                        resultado = n1 + n2;
                        break;
                    case 2:
                        operador = '-';
                        resultado = n1 - n2;
                        break;
                    case 3:
                        operador = 'x';
                        resultado = n1 * n2;
                        break;
                    default:
                        Console.WriteLine("Operador no valido.");
                        break;
                }
            }
            else // Dificil. Aca se agrega el rango del 1-999 y la operacion de division
            {

                n1 = Random.Shared.Next(1, 1000);
                n2 = Random.Shared.Next(1, 1000);
                op = Random.Shared.Next(1, 5);

                switch (op)
                {
                    case 1:
                        operador = '+';
                        resultado = n1 + n2;
                        break;
                    case 2:
                        operador = '-';
                        resultado = n1 - n2;
                        break;
                    case 3:
                        operador = 'x';
                        resultado = n1 * n2;
                        break;
                    case 4:
                        operador = '/';
                        resultado = n1 / n2;
                        break;
                    default:
                        Console.WriteLine("Operador no valido.");
                        break;
                }
            }

        }

        // Esta funcion es la que muestra la operacion random en la interfaz con las etiquetas
        private void MostrarOperacion()
        {
            resultadoTextBox.ForeColor = Color.FromArgb(3, 218, 197);

            n1Label.Text = n1.ToString();
            n2Label.Text = n2.ToString();
            opLabel.Text = operador.ToString();
        }

        // Esta funcion muestra la informacion de la partida actual en la interfaz con etiquetas
        // (cambia dependiendo del jugador que se encuentre jugando en el momento)
        private void ActualizarInfo()
        {
            puntosLabel.Text = jugadores[turno, 0].ToString(); // Aca se muestran los puntos
            aciertosLabel.Text = jugadores[turno, 1].ToString(); // Aca se muestran los aciertos
            erroresLabel.Text = jugadores[turno, 2].ToString(); // Aca se muestran los errores
            vidasLabel.Text = jugadores[turno, 3].ToString(); // Aca se muestran las vidas
            dificultadLabel.Text = jugadores[turno, 4].ToString(); // Aca se muestra la dificultad

            jugadorLabel.Text = "Jugador: " + nombres[turno]; // Y este muestra cual es el jugador activo en el turno actual
        }

        // Funcion para poder guardar los resultadoss de los jugadores en partida (para despues mostrarlos en una tabla a modo de historial de juego)
        private void GuardarResultados()
        {
            for (int i = 0; i < cantJugadores; i++)
            {
                // Se compara la longitud del historial (50) con la cantidad de resultados para verificar si se pueden guardar los datos
                if (cantResultados < historialNombres.Length == true)
                {
                    historialNombres[cantResultados] = nombres[i];
                    historialPuntos[cantResultados] = jugadores[i, 0];

                    cantResultados++; // Aca se incrementa el valor de la cantidad de resultados para que vaya sincronizado con la cantidad de entradas de los arreglos
                }
                else
                {
                    MessageBox.Show("Ya no se pueden guardar mas datos de partidas."); // Message box por si acaso no se puede agregar mas entradas
                }
            }
        }

        // Funcion que ordena los resultados de mayor a menor por medio de los puntos obtenidos por los jugadores
        private void OrdenarResultados()
        {
            // Ciclos for anidados que comparan los valores y se reacomodan
            for (int i = 0; i < cantResultados - 1; i++)
            {
                for (int j = 0; j < cantResultados - 1 - i; j++)
                {
                    if (historialPuntos[j] < historialPuntos[j + 1])
                    {
                        int puntosAux = historialPuntos[j]; // Variable auxiliar que sirve para guardar un dato temporalmente
                        historialPuntos[j] = historialPuntos[j + 1];
                        historialPuntos[j + 1] = puntosAux;

                        // Se tiene que intercambiar el nombre de posicion tambien para que sigan sincronizados ambos arreglos
                        string nombreAux = historialNombres[j]; // Otra variable auxiliar
                        historialNombres[j] = historialNombres[j + 1];
                        historialNombres[j + 1] = nombreAux;
                    }
                }
            }
        }
        
        // Funcion que muestra todos los resultados de las partidas jugadas dentro de la sesion
        private void MostrarResultados()
        {
            OrdenarResultados(); // Primero se ordena

            resultadosDGV.Rows.Clear(); // Se refrescan las filas para evitar que se repitan datos

            for (int i = 0; i < cantResultados; i++)
            {
                resultadosDGV.Rows.Add(historialNombres[i], historialPuntos[i]); // Se anaden las filas con los valores de la posicion de los arreglos,
                                                                                 // la coma separa las columnas
            }

            // Aca se oculta el panel que contiene el juego como tal y el menu, y se muestra el panel de resultados
            juegoPanel.Visible = false;
            menuPanel.Visible = false;
            resultadosPanel.Visible = true;
        }

        // Funcion que aumenta la dificultad cada 5 aciertos, y si tiene mas de 10 llega a la dificultad maxima
        private void AumentarDificultad()
        {
            int aciertos = jugadores[turno, 1];

            if (aciertos < 5)
            {
                jugadores[turno, 4] = 1;
            }
            else if (aciertos < 10)
            {
                jugadores[turno, 4] = 2;
            }
            else
            {
                jugadores[turno, 4] = 3;
            }

        }

        // Funcion que alterna los turnos de los jugadores
        private void CambioTurno()
        {
            if (cantJugadores == 1) // En caso de que la partida no sea multijugador, el valor se mantiene
            {
                turno = 0;
            }
            else if (turno == 0)
            {
                turno = 1;
            }
            else
            {
                turno = 0;
            }

            // Si es de 2 jugadores y al jugador que sigue no le quedan vidas, se continua con el que si tenga
            if (cantJugadores == 2 && jugadores[turno, 3] <= 0)
            {
                if (jugadores[0, 3] > 0)
                {
                    turno = 0;
                }
                else if (jugadores[1, 3] > 0)
                {
                    turno = 1;
                }
            }
        }

        // Funcion que determina un ganador
        private void Ganador()
        {
            if (cantJugadores == 1) // Cuando solo hay un jugador, no hay ganador, solo se acaba el juego
            {
                MessageBox.Show("Partida terminada.");
            }
            else
            {
                // Aca se hacen comparaciones de puntos, el que tiene mas gana, y si tienen lo mismo es empate
                if (jugadores[0, 0] > jugadores[1, 0])
                {
                    MessageBox.Show($"Gana el jugador {nombres[0]}!");
                }
                else if (jugadores[1, 0] > jugadores[0, 0])
                {
                    MessageBox.Show($"Gana el jugador {nombres[1]}!");
                }
                else
                {
                    MessageBox.Show($"Empate!");
                }
            }
        }

        // Funcion que revisa cuando los jugadores se quedan sin vidas
        private bool GameOver()
        {
            for (int i = 0; i < cantJugadores; i++)
            {
                if (jugadores[i, 3] > 0)
                {
                    return false; // Si todavia tienen vidas entonces GameOver es falso
                }
            }

            // Aca solo hago que no se puedan realizar mas acciones deshabilitando el boton y el textbox
            aceptarButton.Enabled = false;
            resultadoTextBox.Enabled = false;

            Ganador(); // Llamada a la funcion Ganador() para el veredicto

            // Aca se guardan los resultados de la partida y despues se muestra el panel de resultados
            GuardarResultados();
            MostrarResultados();

            return true; // Se termina la partida
        }

        // Funcion por defecto de forms, inicializa la ventana de windows
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cuando se abre la ventana, se inicia en el menu y se ocultan los otros paneles
            menuPanel.Visible = true;
            juegoPanel.Visible = false;
            resultadosPanel.Visible = false;

            // Esto funciona simplemente para que por defecto este seleccionado el modo un jugador y solo se muestre un textboz de ingreso de nombre
            unJugadorRB.Checked = true;
            nJugador2TextBox.Visible = false;

        }

        // Funcion que se ejecuta cuando se presiona el boton de aceptar respuesta en el juego
        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(resultadoTextBox.Text, out float respuesta)) // Se valida si el usuario ingresa un dato que no se puede convertir a float (false)
            {
                // Se muestra un mensaje de error en una etiqueta
                resultadoLabel.ForeColor = Color.Red;
                resultadoLabel.Text = "Ingrese un número válido.";
                return; // El retorno sirve para "saltarse" el resto del codigo (o sea salirse de la funcion). Y como la ventana funciona como una especie
                        // de bucle o ciclo, se va a seguir repitiendo hasta que el usuario escriba algo valido
            }

            if (respuesta == resultado) // Si la respuesta es correcta se incrementan los aciertos en 1 y los puntos de 5 en 5
            {
                jugadores[turno, 1]++;
                jugadores[turno, 0] += 5;

                resultadoLabel.ForeColor = Color.Green;
                resultadoLabel.Text = "Correcto!";
            }
            else // Si la respuesta es incorrecta se incrementan los errores en 1 y las vidas se restan en 1
            {
                jugadores[turno, 2]++;
                jugadores[turno, 3]--;

                resultadoLabel.ForeColor = Color.Red;
                resultadoLabel.Text = $"Incorrecto! La respuesta era {resultado}."; // Mensaje que muestra la respuesta correcta
            }

            resultadoTextBox.Clear(); // Se limpia el textbox del resultado para poder ingresar una respuesta nueva

            AumentarDificultad(); // Se llama a la funcion para ver si se puede aumentar la dificultad

            // Message box que indica cuando un jugador se queda sin vidas
            if (jugadores[turno, 3] == 0)
            {
                MessageBox.Show($"El jugador {nombres[turno]} se quedó sin vidas.");
            }

            CambioTurno(); // Se llama a la funcion para cambiar de turno

            // Si el juego se termino, se sale de la funcion con un return y se muestran los resultados dentro de GameOver()
            if (GameOver() == true)
            {
                return;
            }
            else // Si el juego continua, se actualizan los datos y se genera y se muestra una nueva operacion a resolver
            {
                ActualizarInfo();
                OperacionAleatoria();
                MostrarOperacion();
            }
        }

        // Funcion que se ejecuta al presionar el boton de menu, basicamente se reinician algunos valores y se ocultan los demas
        // paneles para mostrar el panel del menu
        private void menuButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
            juegoPanel.Visible = false;
            resultadosPanel.Visible = false;

            unJugadorRB.Checked = true;

            nJugador1TextBox.Clear();
            nJugador2TextBox.Clear();

            nJugador2TextBox.Visible = false;

            resultadoTextBox.Clear();
            resultadoLabel.Text = "";

            aceptarButton.Enabled = true;
            resultadoTextBox.Enabled = true;

            turno = 0;
        }

        // Funcion que se ejecuta al darle click a aceptar despues de ingresar los nombres de jugadores en el menu
        private void aceptarNombreButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nJugador1TextBox.Text)) // Valida que el textbox no quede totalmente en blanco
            {
                MessageBox.Show("Ingrese el nombre del jugador 1."); // Muestra un mensaje de error hasta que se ingrese un dato valido
                return;
            }

            if (dosJugadoresRB.Checked == true) // Si se selecciona 2 jugadores en el radialButton, cantJugadores cambia, si no, se mantiene en 1
            {
                cantJugadores = 2;
            }
            else
            {
                cantJugadores = 1;
            }

            nombres[0] = nJugador1TextBox.Text; // Se agrega el nombre en la posicion correspondiente

            if (cantJugadores == 2)
            {
                if (string.IsNullOrWhiteSpace(nJugador2TextBox.Text)) // Se aplica la misma validacion para el nombre del segundo jugador
                {
                    MessageBox.Show("Ingrese el nombre del jugador 2.");
                    return;
                }

                nombres[1] = nJugador2TextBox.Text; // Se agrega el nombre en la posicion correspondiente
            }

            turno = 0;

            // Se inicializa la matriz y la informacion, y se randomiza la primera operacion antes de cambiar al panel de juego
            IniciarJugadores();
            ActualizarInfo();
            OperacionAleatoria();
            MostrarOperacion();

            // Se ocultan los demas paneles y se muestra el panel de juego
            resultadosPanel.Visible = false;
            menuPanel.Visible = false;
            juegoPanel.Visible = true;
        }

        // Funcion que determina si se muestra o no el textbox para el nombre de un segundo jugador de ser el caso que
        // se seleccione el modo de 2 jugadores
        private void dosJugadoresRB_CheckedChanged(object sender, EventArgs e)
        {
            if (dosJugadoresRB.Checked == true)
            {
                nJugador2TextBox.Visible = true;
            }
            else
            {
                nJugador2TextBox.Visible = false;
            }
        }

    }
}