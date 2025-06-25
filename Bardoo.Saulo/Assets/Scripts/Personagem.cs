using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int nivel;
    public int vida;
    public int ataque;

    public string GetNome() => nome;
    public void SetNome(string novoNome) => nome = novoNome;

    public int GetNivel() => nivel;
    public void SetNivel(int novoNivel) => nivel = novoNivel;

    public int GetVida() => vida;
    public void SetVida(int novaVida) => vida = novaVida;

    public int GetAtaque() => ataque;
    public void SetAtaque(int novoAtaque) => ataque = novoAtaque;

    public void CompararNivel(Personagem outro)
    {
        if (this.nivel > outro.nivel)
        {
            Debug.Log($"{nome} é de nível mais alto que {outro.nome}");
        }
        else if (this.nivel < outro.nivel)
        {
            Debug.Log($"{nome} é de nível mais baixo que {outro.nome}");
        }
        else
        {
            Debug.Log($"{nome} e {outro.nome} estão no mesmo nível");
        }
    }
}
