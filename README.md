# Caminhos em Marte

![Captura de tela 2024-09-22 111609](https://github.com/user-attachments/assets/20dd5639-985e-4ca1-ab74-de51dabc6afa)

## Descrição

O **Caminhos em Marte** é uma aplicação desktop em C# que permite gerenciar cidades e seus caminhos em um mapa, utilizando diferentes técnicas de tabela hash para armazenar dados das cidades. A aplicação é voltada para a visualização de caminhos e distâncias entre cidades, utilizando um grafo.

## Funcionalidades

- **Gerenciamento de Cidades**:
  - Leitura de dados de cidades de arquivos texto com escolha correlação ao modo de armazenar os dados.
  - Inserção, remoção e busca de cidades com suas coordenadas.
  - Listagem das cidades em um mapa interativo.

- **Gerenciamento de Caminhos**:
  - Criação de conexões entre cidades com distâncias especificadas.
  - Exclusão de caminhos entre cidades.
  - Alteração de distâncias de caminhos existentes.
  - Busca por todos os caminhos possíveis entre duas cidades e cálculo da menor rota.

- **Visualização**:
  - Desenho das cidades em um mapa com suas respectivas conexões.

## Testes

### Leitura do arquivo de cidades
<img src="https://github.com/user-attachments/assets/5c994d2b-c67a-4898-92d9-fa2899354233" alt="Teste de Leitura do arquivo de cidades">
<img src="https://github.com/user-attachments/assets/c84ac8e3-4014-4635-82b9-fa4b97b5690f" alt="Resultado da Leitura do arquivo de cidades">

### Adicionar cidade
<img src="https://github.com/user-attachments/assets/c1bdc0f6-bc78-4b8e-bd08-1c6b88939741" alt="Preparação para adicionar cidade">
<img src="https://github.com/user-attachments/assets/797bfdb8-d4ea-40a8-85c5-2e04a8661072" alt="Cidade adicionada">

### Remover cidade
<img src="https://github.com/user-attachments/assets/bd0c105a-da3f-426f-9076-dfd4a9568d7a" alt="Preparação para remover cidade">
<img src="https://github.com/user-attachments/assets/0420cbdb-36b1-47f2-9127-de6b3accef02" alt="Cidade remmovida">

### Procurar cidade
<img src="https://github.com/user-attachments/assets/008dabeb-f570-4401-9f40-8d5c8cb1a7df" alt="Preparação para procurar cidade">
<img src="https://github.com/user-attachments/assets/0bafb991-bb2e-411d-ba14-c3a579a634a4" alt="Cidade encontrada">

### Listar cidades
<img src="https://github.com/user-attachments/assets/d6eb77c1-3f38-452e-9006-b86bf2abadb9" alt="Cidades listadas">

### Leitura do arquivo de caminhos entre cidades
<img src="https://github.com/user-attachments/assets/4042ce4d-7252-4990-8295-5c0c6c5421ef" alt="Teste de Leitura do arquivo de cidades">
<img src="https://github.com/user-attachments/assets/3ecf4cd8-2324-4988-94f2-6c3a9f304c7c" alt="Teste de Leitura do arquivo de caminhos entre cidades">
<img src="https://github.com/user-attachments/assets/1545517f-c69f-489e-bb33-d57fb751cf54" alt="Resultado da leitura dos arquivos">

### Adicionar caminho entre cidades
<img src="https://github.com/user-attachments/assets/4d31c81c-605e-42fb-a2d3-73831e1570f6" alt="Preparação para adicionar caminho entre cidades">
<img src="https://github.com/user-attachments/assets/b5eedc61-8afc-4a84-868d-cab9d9b0add6" alt="Caminho adicionado">

### Remover caminho entre cidades
<img src="https://github.com/user-attachments/assets/f6b9ca93-4f4e-46c6-9826-255383eca187" alt="Preaparação pararemover caminho entre cidades">
<img src="https://github.com/user-attachments/assets/4ecfaa6b-4f91-4cbc-b472-52b754744529" alt="Caminho removido">

### Alterar caminho entre cidades
<img src="https://github.com/user-attachments/assets/d5d545f2-98da-4dc0-b02f-c302347a8a26" alt="Preparação para alterar caminho entre cidades">
<img src="https://github.com/user-attachments/assets/7c8c2f66-5584-4fc4-8140-c9777fb93509" alt="Caminho alterado">

### Buscar todos os caminhos entre duas cidades
<img src="https://github.com/user-attachments/assets/d0e06e2b-44ff-4285-86ae-825c9925f4bc" alt="Preparação para buscar todos os caminhos">
<img src="https://github.com/user-attachments/assets/1caecfb8-1e31-44e6-a517-21d1af547dc5" alt="Exibição do caminho 1">
<img src="https://github.com/user-attachments/assets/1bc3e669-03e8-4c00-826a-adcc980c7e6e" alt="Exibição do caminho 2">
<img src="https://github.com/user-attachments/assets/ce2e478b-8377-4bd7-9b26-53ee3f36f8f4" alt="Exibição do caminho 3">

### Salvar as alterações dos dados
<img src="https://github.com/user-attachments/assets/75379d2d-145b-4a42-8279-44b7bcb3938e" alt="Preaparação para salvar os dados e fechar o programa">
<img src="https://github.com/user-attachments/assets/34cb73cc-f9a3-465e-acf9-d1f5bf97e7cb" alt="Gravando os dados no arquivo de cidades">
<img src="https://github.com/user-attachments/assets/67d11611-35a2-4281-9003-f0c688b9193b" alt="Gravando os dados no arquivo de caminhos">

## Tecnologias utilizadas

- C#
- Windows Forms
- Algorítmos de hash
- Algoritmos de grafos
- Algoritmos de pilhas
- Backtracking
