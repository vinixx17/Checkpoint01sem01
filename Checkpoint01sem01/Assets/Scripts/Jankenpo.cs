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

    int escolhaPlayer;
    int escolhaCPU;

    int pedraCPU = 1;
    int papelCPU = 2;
    int tesouraCPU = 3;

    int pontosCPU;
    int pontosPlayer;

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

        else
        {

            if (pedraPlayer == true)
            {
                escolhaPlayer = pedraPlayerEscolha;
                print("Jogador escolheu Pedra");
            }
            else if (papelPlayer == true)
            {
                escolhaPlayer = papelPlayerEscolha;
                print("Jogador escolheu Papel");
            }
            else if (tesouraPlayer == true)
            {
                escolhaPlayer = tesouraPlayerEscolha;
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

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (escolhaCPU == escolhaPlayer)
            {
                print("Empate");
            }
            else
            {
                if (escolhaCPU == 1 && escolhaPlayer == 2)
                {
                    pontosCPU = pontosCPU + 1;
                    print("CPU ganhou 1 ponto");
                }
                else if (escolhaCPU == 2 && escolhaPlayer == 3)
                {
                    pontosCPU = pontosCPU + 0;
                    print("CPU não ganhou ponto");
                }
                else if (escolhaCPU == 3 && escolhaPlayer == 1)
                {
                    pontosCPU = pontosCPU + 1;
                    print("CPU ganhou 1 ponto");
                }

                else if (escolhaCPU == 3 && escolhaPlayer == 2)
                {
                    pontosCPU = pontosCPU + 0;
                    print("CPU não ganhou ponto");

                }

                //----------------------------------------------------------


                if (escolhaPlayer == 1 && escolhaCPU == 2)
                {
                    pontosPlayer = pontosPlayer + 1;
                    print("Palyer ganhou 1 ponto");
                }
                else if (escolhaPlayer == 2 && escolhaCPU == 3)
                {
                    pontosPlayer = pontosPlayer + 0;
                    print("Palyer não ganhou ponto");
                }
                else if (escolhaPlayer == 3 && escolhaCPU == 1)
                {
                    pontosPlayer = pontosPlayer + 1;
                    print("Palyer ganhou 1 ponto");
                }
                else if (escolhaPlayer == 3 && escolhaCPU == 2)
                {
                    pontosPlayer = pontosPlayer + 0;
                    print("Palyer não ganhou ponto");

                }

                //-----------------------------------------

                if (pontosCPU == 3)
                {

                    print("CPU Ganhou");
                }
                else if (pontosPlayer == 3)
                {
                    
                        print("Player Ganhou");

                    }

                print("Pontos da CPU " + pontosCPU + " Pontos do Player " + pontosPlayer);

                /*
                int pedraCPU = 1;
                int papelCPU = 2;
                int tesouraCPU = 3;
                */

            }
            }
        }
    }

