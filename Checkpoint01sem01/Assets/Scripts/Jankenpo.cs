using UnityEngine;

public class Jankenpo : MonoBehaviour
{


    [Header("Escolha entre Pedra, Papel ou Tesoura")]


    [SerializeField] bool pedraPlayer;
    [SerializeField] bool papelPlayer;
    [SerializeField] bool tesouraPlayer;

    int pedraPlayerEscolha = 1;
    int papelPlayerEscolha = 2;
    int tesouraPlayerEscolha = 3;



    int escolhaCPU;

    int pedraCPU = 1;
    int papelCPU = 2;
    int tesouraCPU = 3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pedraPlayer == false && papelPlayer == false && tesouraPlayer == false)
        {
            print("Escolha entre Pedra, Papel ou Tesoura para iniciar");
        }
        else if (pedraPlayer == true && papelPlayer == true || pedraPlayer == true && tesouraPlayer == true || papelPlayer == true && tesouraPlayer == true)
        {
            print("Escolha apenas uma opção");
        }

        else {

            if (pedraPlayer == true)
            {
                print("Jogador escolheu Pedra");
            }
            else if (papelPlayer == true)
            {
                print("Jogador escolheu Papel");
            }
            else if (tesouraPlayer == true)
            {
                print("Jogador escolheu Tesoura");
            }
        }

        escolhaCPU = Random.Range(1, 4);

        if (escolhaCPU == 1)
        {
            escolhaCPU = pedraCPU;
            print("CPU escolheu Pedra");
        }

        else if (escolhaCPU == 2)
        {
            escolhaCPU = papelCPU;
            print("CPU escolheu Papel");
        }

        else
        {
            escolhaCPU = tesouraCPU;
            print("CPU escolheu Tesoura");
        }



            // Update is called once per frame
            void Update()
            {

            }
    }
}