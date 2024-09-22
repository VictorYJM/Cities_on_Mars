using System;
using System.IO;

public interface IRegistro<Tipo> where Tipo : IComparable<Tipo>
{
  void LerRegistro(StreamReader arquivo);
  void GravarDados(StreamWriter arquivo);
  string Chave { get; }
}

