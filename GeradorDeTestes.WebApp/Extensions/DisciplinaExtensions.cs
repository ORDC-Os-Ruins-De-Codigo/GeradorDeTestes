﻿namespace GeradorDeTestes.WebApp.Extensions
{
    public static class DisciplinaExtensions;

    public static class DisciplinaExtensions
    {
        public static Disciplina ParaEntidade(this FormularioDisciplinaViewModel formularioVM)
        {
            return new Disciplina(formularioVM.Titulo);
        }

        public static DetalhesDisciplinaViewModel ParaDetalhesVM(this Disciplina categoria)
        {
            return new DetalhesDisciplinaViewModel(
                    categoria.Id,
                    categoria.Nome,
                    categoria.Materia
            );
        }
    }
}
