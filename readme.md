

# Exemplo Async Await .Net Core

Aplica��o de exemplo para ilustrar o funcionamento de async e await em .Net Core.
Ver exeplica��o em: [EM ANDAMENTO]

## Executar testes

Com a utiliza��o da ferramenta Siege (tutorial para instala��o em [Linux](https://www.tecmint.com/load-testing-web-servers-with-siege-benchmarking-tool/) e [Windows](https://github.com/ewwink/siege-windows)) podemos realizar os seguintes testes e verificar a cria��o das threads.

Primeiramente, compile e execute a aplica��o:

```
dotnet publish -c Release -r win-x64 --output ./output async-await-example.sln
dotnet .\output\async-await-example.dll
```

Enquanto a aplica��o executa, � poss�vel testar os endpoints s�ncronos e ass�ncronos do dash. Primeiramente o s�ncrono:

```
.\siege.exe -c 50 -b http://localhost:5000/addresses?cep=25976016
```

E o ass�ncrono:

```
.\siege.exe -c 50 -b http://localhost:5000/addresses/sync?cep=25976016
```

**Nota**: Pelo uso do Task.Delay, este exemplo e a diferen�a de desempenho entre as duas chamadas, n�o necessariamente refletem toda a complexidade da execu��o de I/O com alta lat�ncia em um ambiente de produ��o. A diferen�a de desempenho das duas aplica��es dificilmente seria observada em um ambiente real e servem apenas para ilustrar o resultado de boas pr�ticas recomendadas nas documenta��o dos .Net Core.