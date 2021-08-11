<p align="center"> <img alt="Logo do softPrice" src="./logo.png"> </p>

### 🤑 SoftPrice é um protótipo de software desenvolvido durante minha faculdade cujo objetivo é fazer a precificação de projetos de software em Windows Forms.

## ⚠ Importante!

O SoftPrice tinha, antes de tudo, o princípio de ser um projeto acadêmico para o desenvolvimento e demonstração de um sistema em Windows Forms. Assim, seus métodos e cálculos para a precificação não são 100% corretos ou precisos.

## Pré-requisitos

Para executar o SoftPrice localmente, você precisa:

- Servidor MySQL;
- Servidor Apache para acessar o phpMyAdmin;

    **ou então**

- Programa que gerencie o servidor MySQL (como SQLyog).
 
 
Para ativar esses servidores, será preciso:
- Um ambiente para controlar servidores web (XAMPP, WampServer, etc.).

## ▶ Executando o sistema

O seguinte tutorial será feito com base no XAMPP, ou seja, o banco de dados será importado através do phpMyAdmin. Existem outras maneiras possíveis de cumprir o mesmo 
processo, desde que seja importado um banco de dados MySQL com o nome **softprice** através do arquivo **softprice.sql**.

1. Baixe ou clone o atual repositório em seu computador
2. Baixe e instale o XAMPP através do site https://www.apachefriends.org/pt_br/download.html
3. Após a instalação, no painel do XAMPP, inicie os serviços Apache e MySQL pelo botão "Start"
4. Pelo navegador, entre no phpMyAdmin pelo link **localhost/phpmyadmin**
5. Na barra lateral à esquerda, clique na opção "Novo" e crie um banco de dados com o nome **softprice**
6. Na barra superior, clique na opção "Importar" e selecione o arquivo **softprice.sql** com o botão "Escolher arquivo", este arquivo se encontra dentro da pasta **Banco de dados**
7. Role a página para baixo e clique no botão "Executar"
8. Navegue até a pasta **bin/debug** e abra o software pelo arquivo **softPrice.exe**
9. Agora é só utilizar o SoftPrice. Aproveite! 😁

*Obs:* Caso possua alguma configuração diferente no seu servidor MySQL local, o arquivo que estabelece conexão com o banco de dados está na pasta **Controller/Conexao.cs**

## 🛠 Tecnologias
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET](https://dotnet.microsoft.com/)
  - [Windows Forms](https://docs.microsoft.com/pt-br/dotnet/desktop/winforms/overview/?view=netdesktop-5.0)
- [MySQL](https://www.mysql.com/)
