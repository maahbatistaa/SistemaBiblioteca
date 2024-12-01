## Sistema de Biblioteca
Um projeto simples de console para gerenciar livros em uma biblioteca, desenvolvido em C# para praticar conceitos fundamentais da linguagem.

### Funcionalidades
- Adicionar livros à biblioteca
- Listar todos os livros disponiveis no acervo
- Emprestar livros marcando-os como "emprestados"
- Devolver livros marcando-os como "disponíveis"

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
- `Livro.cs`: Classe que representa o modelo de um livro com propriedades como Id, Titulo, Autor e Status (Emprestado ou Disponivel)
- `Program.cs`: Lógica principal do sistema com o menu interativo e as funcionalidades.

### Como usar
1. Adiconar Livro:
  - Insira o título e o autor para cadastrar um novo livro na biblioteca.
2. Listar Livros:
  - Visualize todos os livros cadastrados e seus respectivos status.
3. Emprestar Livro:
  - Informe o ID de um livro disponivel para marca-lo como emprestado.
4. Devolver Livro:
  - Informe o ID de um livro emprestado para marca0lo como disponivel novamente.

### Proximos Passos
- [ ] Implementar OOP 
- [ ] Implementar pesquisa de livros por titulo ou autor
- [ ] Implementar opção de remover livros
- [ ] Implementar opção de atualizar livros
- [ ] Implementar persistencia de dados com JSON ou Banco de Dados
- [ ] Implementar histórico de empréstimos

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