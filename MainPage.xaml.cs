namespace Ejercicio1;

public partial class MainPage : ContentPage

{

    public MainPage()

    {

        InitializeComponent();

    }

    ///<Summary>
    ///<Createddate>03-07-2023</createddate>
    ///<company>SandBox</company>
    ///<lastmodificationdate>03-07-2023</lastmodificationdate>
    ///<lastmodificationdescription>Ninguna</lastmodificationdescription>
    ///<lastmodifierautor>Nery</lastmodifierautor>
    ///</Summary>

    private void OnCounterClicked(object sender, EventArgs e)

    // Utilizamos el metodo creado, y definimos las variables correspondientes//

    {

        var numeros = new List<int>

            {

                int.Parse(Numero1.Text),

                int.Parse(Numero2.Text),

                int.Parse(Numero3.Text),

                int.Parse(Numero4.Text)

            };

        numeros.Reverse();

        var resultado = string.Join(", ", numeros);

        // Mostramos el resultado con la propiedad DisplayAlert y un mensaje personalizado //

        DisplayAlert("Números invertidos", resultado, "Aceptar");

    }

}
