# C#
### MÓDULO 5
- Construtores;
- this;
- Sobrecarga;
- Encapsulamento.

<br><br>

## CONTEÚDO
- Contrutores;
  - Ctor (atalho);
- Sobrecarga e instância para construtor default:
~~~C#
int Valor1;
string Valor2;
public NomeClasse(){}; // constutor default

// instânciar 

NomeClasse EXEMPLO = new NomeClasse();

// ou

NomeClasse EXEMPLO = new NomeClasse
{
  Valor1 = 2,
  Valor2 = "valor2"
};

