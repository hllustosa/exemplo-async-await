

# Exemplo Async Await .Net Core

Aplicação de exemplo para ilustrar o funcionamento de async e await em .Net Core.
Ver exeplicação em: [EM ANDAMENTO]

## Executar testes

Com a utilização da ferramenta Siege (tutorial para instalação em [Linux](https://www.tecmint.com/load-testing-web-servers-with-siege-benchmarking-tool/) e [Windows](https://github.com/ewwink/siege-windows)) podemos realizar os seguintes testes e verificar a criação das threads.

Primeiramente, compile e execute a aplicação:

```
dotnet publish -c Release -r win-x64 --output ./output async-await-example.sln
dotnet .\output\async-await-example.dll
```

Enquanto a aplicação executa, é possível testar os endpoints síncronos e assíncronos do dash. Primeiramente o síncrono:

```
.\siege.exe -c 50 -b http://localhost:5000/addresses?cep=25976016
```

E o assíncrono:

```
.\siege.exe -c 50 -b http://localhost:5000/addresses/sync?cep=25976016
```

**Nota**: Pelo uso do Task.Delay, este exemplo e a diferença de desempenho entre as duas chamadas, não necessariamente refletem toda a complexidade da execução de I/O com alta latência em um ambiente de produção. A diferença de desempenho das duas aplicações dificilmente seria observada em um ambiente real e servem apenas para ilustrar o resultado de boas práticas recomendadas nas documentação dos .Net Core.