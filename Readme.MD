# C# consumindo API, gravando arquivos e utilizando o LINQ - Alura
O uso do LINQ no C# oferece uma sintaxe elegante e eficaz para consultas(banco ou API) e manipulação de dados, tornando o código mais legível, conciso e fácil de manter. 

## Tópicos abordados
- Requisições assíncronas para uma API externa utilizando HTTP;
- Deserializacao dos dados p/ uma classe;
- Uso do LINQ no C#;
- Criar um arquivo JSON e TXT com propriedades específicas;
- Vincular o arquivo JSON com o front-end da aplicação.

### Pontos de atenção
- Sempre que um endpoint for passado numa chamada eu DEVO colocá-lo dentro de um try-catch, pois o endereço pode mudar e eu preciso capturar e tratar a exceção dentro do meu programa.
<br>

Link da interface p/ integração: https://screen-sound.vercel.app/


#### Desafio 1
Buscar o valor numérico da propriedade key e convertê-lo à uma nota musical.

#### Desafio 2
Exibir todas as músicas que estejam na tonalidade de C#