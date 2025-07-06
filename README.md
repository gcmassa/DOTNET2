# 📘 Explicação do Código C# — Operações Aritméticas, Atribuições e Conversões

Este código demonstra conceitos essenciais da linguagem C#, como operações aritméticas, operadores de atribuição, conversão de tipos (casting) e manipulação de strings.

---

## 🔢 1. Operações Aritméticas com Inteiros e Atribuição de variáveis

```csharp
int a = 10;
int b = 20;
int c = a + b;
```

### 🔹 1.1 Declaração e Soma
- Três variáveis inteiras são declaradas.
- `c` recebe a soma de `a` e `b` (10 + 20 = 30).

---

## ➕ 2. Operadores de Atribuição Composta

```csharp
c += 5;
Console.WriteLine(c);

c -= 5;
Console.WriteLine(c);

c *= 5;
Console.WriteLine(c);
```

### 🔹 2.1 `+=` (Soma e atribuição)
- Equivalente a `c = c + 5`.

### 🔹 2.2 `-=` (Subtração e atribuição)
- Equivalente a `c = c - 5`.

### 🔹 2.3 `*=` (Multiplicação e atribuição)
- Equivalente a `c = c * 5`.

🖨️ **Exemplo de saída:**
```
35
30
150
```

---

## 🔁 3. Conversão de Tipos (Casting)

### 🔹 3.1 Usando `Convert.ToInt32()`

```csharp
a = Convert.ToInt32("5");
Console.WriteLine(a);
```

- Converte uma string numérica para inteiro.
- Aceita valores nulos (`null`) sem lançar exceção — retorna `0`.

### 🔹 3.2 Usando `int.Parse()`

```csharp
b = int.Parse("10");
Console.WriteLine(b);
```

- Também converte string para inteiro.
- **Não aceita valores nulos** — lança exceção se `null` for passado.

### 🔹 3.3 Diferença entre `Convert` e `Parse`

```csharp
a = Convert.ToInt32(null);
Console.WriteLine(a);
```

- `Convert.ToInt32(null)` retorna `0`.
- `int.Parse(null)` lançaria uma exceção (`ArgumentNullException`).

---

## 🔤 4. Conversão de Inteiro para String

```csharp
int inteiro = 5;
string d = inteiro.ToString();
Console.WriteLine(d);
```

- Converte um número inteiro para uma string usando `.ToString()`.

---

## ➗ 5. Precedência de Operadores

```csharp
double k = 4 / 2 + 2;
Console.WriteLine(k);
```

### 🔹 5.1 Ordem de execução
- Primeiro: `4 / 2 = 2`
- Depois: `2 + 2 = 4`

🧠 **Importante:** Como todos os operandos são inteiros, a divisão é inteira. O resultado final é atribuído a um `double`, mas o cálculo já foi feito como inteiro.

---

## 🗃️ 6. Código Comentado

```csharp
/*
int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine(c);
*/
```

- Esta parte está comentada e não será executada.
- Serve como exemplo de código anterior ou para testes futuros.

---

## 🧠 Conclusão

Este código cobre:

- ✅ Operações aritméticas básicas
- ✅ Uso de operadores de atribuição composta (`+=`, `-=`, `*=`)
- ✅ Conversão entre tipos (`string` ↔ `int`)
- ✅ Diferença entre `Convert` e `Parse`
- ✅ Conversão de `int` para `string`
- ✅ Precedência de operadores
