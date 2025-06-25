using UnityEngine;

public class TesteRPG : MonoBehaviour
{
    void Start()
    {
        Bardo bardo1 = gameObject.AddComponent<Bardo>();
        bardo1.SetNome("Lírico");
        bardo1.SetNivel(5);
        bardo1.SetVida(100);
        bardo1.SetAtaque(15);

        Personagem generico = gameObject.AddComponent<Personagem>();
        generico.SetNome("NPC");
        generico.SetNivel(3);
        generico.SetVida(80);
        generico.SetAtaque(10);

        Debug.Log("Nome: " + bardo1.GetNome());
        Debug.Log("Vida: " + bardo1.GetVida());
        Debug.Log("Ataque: " + bardo1.GetAtaque());

        bardo1.TocarMusica();
        bardo1.CompararNivel(generico);
    }
}
