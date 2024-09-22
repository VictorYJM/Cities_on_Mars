# Caminhos em Marte

## Descrição

O **Caminhos em Marte** é uma aplicação desktop em C# que permite gerenciar cidades e seus caminhos em um mapa, utilizando diferentes técnicas de tabela hash para armazenar dados das cidades. A aplicação é voltada para a visualização de caminhos e distâncias entre cidades, utilizando um grafo.

## Funcionalidades

- **Gerenciamento de Cidades**:
  - Leitura de dados de cidades de arquivos texto.
  - Inserção, remoção e busca de cidades com suas coordenadas.
  - Listagem das cidades em um mapa interativo.

- **Gerenciamento de Caminhos**:
  - Criação de conexões entre cidades com distâncias especificadas.
  - Exclusão de caminhos entre cidades.
  - Alteração de distâncias de caminhos existentes.
  - Busca por todos os caminhos possíveis entre duas cidades e cálculo da menor rota.

- **Visualização**:
  - Desenho das cidades em um mapa com suas respectivas conexões.

## Instalação

Para rodar o projeto, você precisará do .NET Framework. Siga os passos abaixo:

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/caminhos-em-marte.git
