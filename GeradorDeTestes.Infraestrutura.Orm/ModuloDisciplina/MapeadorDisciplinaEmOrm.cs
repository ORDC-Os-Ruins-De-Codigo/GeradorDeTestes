﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeradorDeTestes.Infraestrutura.Orm.ModuloDisciplina;
public class MapeadorDisciplinaEmOrm : IEntityTypeConfiguration<Disciplina>
{
    public void Configure(EntityTypeBuilder<Disciplina> builder) {
        builder.Property(d => d.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.Property(d => d.Nome)
            .IsRequired();

        builder.HasMany(d => d.Materias)
            .WithOne(m => m.Disciplina)
            .IsRequired();

        builder.HasMany(d => d.Testes)
            .WithOne(t => t.Disciplina);
    }
}
