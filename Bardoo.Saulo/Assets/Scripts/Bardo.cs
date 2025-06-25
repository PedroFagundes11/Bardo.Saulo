using UnityEngine;

public class Bardo : Personagem
{
    public string instrumentoMusical = "Alaúde";
    public string habilidadeEspecial = "Canção de Batalha";

    public void TocarMusica()
    {
        Debug.Log($"{nome} toca uma melodia poderosa com seu {instrumentoMusical}!");
        Debug.Log($"Habilidade Especial: {habilidadeEspecial}");
    }
}
