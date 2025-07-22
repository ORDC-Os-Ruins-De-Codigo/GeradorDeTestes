﻿using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloDisciplina;

namespace GeradorDeTestes.Dominio.ModuloTeste;
public class Teste : EntidadeBase<Teste>
{
    public string Titulo { get; set; } = string.Empty;
    public ModuloDisciplina.Disciplina? Disciplina { get; set; }
    public Materia? Materia { get; set; }
    public Serie Serie { get; set; }
    public int QuantidadeQuestoes { get; set; }
    public TipoTeste TipoTeste { get; set; }

    public Teste() { }

    public Teste(string titulo, ModuloDisciplina.Disciplina disciplina, Materia? materia, Serie serie, int quantidadeQuestoes, TipoTeste tipoTeste) {
        Titulo = titulo;
        Disciplina = disciplina;
        Materia = materia;
        Serie = serie;
        QuantidadeQuestoes = quantidadeQuestoes;
        TipoTeste = tipoTeste;
    }

    public override void AtualizarRegistro(Teste registroEditado) {
        Titulo = registroEditado.Titulo;
        Disciplina = registroEditado.Disciplina;
        Materia = registroEditado.Materia;
        Serie = registroEditado.Serie;
        QuantidadeQuestoes = registroEditado.QuantidadeQuestoes;
        TipoTeste = registroEditado.TipoTeste;
    }
}
