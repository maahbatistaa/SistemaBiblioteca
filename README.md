## Sistema de Biblioteca
Um projeto simples de console para gerenciar livros em uma biblioteca, desenvolvido em C# para praticar conceitos fundamentais da linguagem.

### Funcionalidades
- Adicionar livros à biblioteca
- Listar todos os livros disponiveis no acervo
- Emprestar livros 
- Devolver livros 
- Listar emprestimos
- Adicionar usuários
- Listar usuários

### Como executar o projeto 
#### Pré-requisitos
- .NET Framework ou .NET Core SDK configurado

#### Passos para executar o projeto
1. Clone o repositório para sua máquina local.
   ```shell 
   git clone https://github.com/maahbatistaa/SistemaBiblioteca.git
   ```
2. Abra o projeto em sua IDE
3. Compile e execute o projeto.
4. Use o menu interativo no console para navegar pelas funcionalidades

### Estrutura do Projeto
#### 1. **SistemaBiblioteca/Models/**
- **`Livro.cs`**: Define os livros na biblioteca, com informações como título, autor e estado de empréstimo.
- **`Usuario.cs`**: Define os usuários do sistema, com propriedades como nome, email e métodos para exibição de informações.
- **`Emprestimo.cs`**: Define os empréstimos de livros pelos usuários, com a data de empréstimo e de devolução.

#### 2. **SistemaBiblioteca/Services/**
- **`Biblioteca.cs`**: Responsável pelas operações de gerenciamento de livros, usuários e empréstimos. Inclui funcionalidades como adicionar livros, listar livros e controlar o empréstimo de livros.

#### 3. **SistemaBiblioteca/UI/**
- **`Menu.cs`**: Exibe o menu interativo para o usuário, permitindo que ele escolha opções para interagir com o sistema, como adicionar livros, registrar usuários e realizar empréstimos.

### Proximos Passos
- [X] Implementar OOP 
- [X] Implementar cadastro de usuarios
- [X] Implementar histórico de empréstimos
- [ ] Implementar pesquisa de livros por titulo ou autor
- [ ] Implementar opção de remover livros
- [ ] Implementar opção de atualizar livros
- [ ] Implementar persistencia de dados com JSON ou Banco de Dados

### Tecnologias Utilizadas
- C#
- .NET Framework ou .NET Core SDK
  
### Contribuiições
- Contribuições são bem-vindas! Para contribuir, siga as etapas abaixo:
  1. Faça um fork do repositório
  2. Crie uma branch para sua funcionalidade (`git checkout -b minha-feature`)
  3. Realize um commit com suas alterações (`git commit -m 'Adicionando uma nova funcionalidade'`)
  4. Envie um push para a branch (`git push origin minha-feature`)
  5. Abra um pull request

### Autor
- **Autor**: Mariana Batista