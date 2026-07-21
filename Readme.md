# Jogo da Velha

Este é o repositório oficial de testes para o desenvolvimento do nosso projeto de Jogo da Velha em C# (.NET) no VS CODE.

---

## Equipe do Projeto

*   **Gabriel** —
*   **Cristopher** —
*   **Madirce** — 

---

## Como Executar o Projeto Localmente

Se você acabou de clonar o repositório, siga os passos abaixo no terminal do seu VS Code:

1. **Restaurar as dependências do projeto:**
   ```bash
   dotnet restore
   ```

2. **Compilar e rodar o jogo:**
   ```bash
   dotnet run
   ```

---

## Regras de Branch e Fluxo de Trabalho (Git)

Para mantermos o projeto organizado durante os testes, siga estas regras antes de alterar qualquer código:

1. **Nunca altere o código direto na branch `master` ou `main`.**
2. Crie a sua própria branch para trabalhar:
   ```bash
   git checkout -b minha-branch (temos 2 colaboradores)
   para checar branch, use git branch.
   ```
3. Ao terminar suas alterações, envie sua branch para o GitHub:
   ```bash
   git add .
   git status
   git commit -m "Explique brevemente o que você fez"
   git push -u origin HEAD
   ```
