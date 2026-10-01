# 📜 Paws Place v2 — Histórico de etapas

> Um registro curto por etapa concluída: o que foi feito e os **principais** aprendizados.
> Entrada mais recente no topo. O checklist das etapas fica em [ROADMAP-V2.md](ROADMAP-V2.md).

<!--
Modelo de entrada (copiar ao fechar uma etapa):

## Etapa N — Título (AAAA-MM-DD)

**O que foi feito**
- ...

**Principais aprendizados**
- ...

**Paralelo com o trabalho** (opcional)
- ...

**Pendências** (se houver)
- ...
-->

## Etapa 1 — O que é uma API, na prática (2026-10-01) — ⏳ em andamento

**O que foi feito**
- Solution `src/PawsPlace.slnx` + projeto `PawsPlace.Api` (.NET 10), com OpenAPI e Scalar (`/scalar`).
- `Program.cs` comentado: parte 1 = serviços (DI), parte 2 = pipeline (middlewares, em ordem).
- **Vini escreveu** o `AnimaisController`: `GET /api/animais` e `GET /api/animais/{id}` com lista em memória.
- Testado: 200 (lista e id 1), 404 (id 99), 400 (id "abc").

**Principais aprendizados**
- Atributo (`[Route]`, `[HttpGet]`) é uma etiqueta: precisa estar **em cima** de uma classe/método. Sem `using Microsoft.AspNetCore.Mvc` o compilador não os reconhece.
- `IActionResult` permite devolver respostas diferentes no mesmo método (`Ok()` 200, `NotFound()` 404).
- Lambda no `FirstOrDefault` é uma **pergunta sim/não** (`a => a.Id == id`); `==` compara, `=` atribui. C# diferencia maiúsculas.
- O `return` encerra o método; todo caminho precisa de um `return`. As chaves `{ }` são a fronteira do `if`.
- Ler erro do compilador: `(linha,coluna)` + código (`CS1002`) + mensagem.
- Status code comunica o resultado sem o front precisar abrir o corpo; `[ApiController]` já devolve 400 sozinho para entrada inválida.
- Salvar o arquivo antes de compilar 🙂 (o compilador lê o disco, não o editor).

**Paralelo com o trabalho**
- Os controllers do PierBack seguem a mesma anatomia: atributos + `ControllerBase` + métodos retornando resultados HTTP.

**Pendências**
- Vini escrever as chamadas no `PawsPlace.Api.http` (lista, id 1, id 99, id "abc") e testar pelo VS.
- Apagar o `WeatherForecast` de exemplo e commitar a etapa.

## Etapa 0 — Preparação (2026-09-30)

**O que foi feito**
- Descoberto que o checkout local estava 84 commits atrás: o back .NET 8 só existia no `origin/main`.
- Criada a branch `v2` a partir do `origin/main`, **sem upstream**, para um `git push` não cair na `main`.
- `.gitignore` corrigido: ele ignorava `*.sln` e só cobria `bin/obj` dentro de `backend/`.
- Criados `CLAUDE.md` (contexto + modo guiado), `docs/ROADMAP-V2.md` e este histórico.
- Analisada a skill `fluxo-de-card` do trabalho, como modelo para as skills deste projeto.

**Principais aprendizados**
- **CLAUDE.md × skill × AGENTS.md:**
  - o CLAUDE.md é carregado em toda conversa (regras gerais);
  - a skill só entra quando o pedido bate com a `description` (receita de tarefa);
  - o AGENTS.md é o padrão de outras ferramentas e o Claude Code não lê sozinho.
- Antes de começar, confira se o local está em dia com o remoto (`git fetch` + `git log origin/main`).
- Uma branch com upstream na `main` é um risco: o `push` sem argumentos vai para lá.
- Uma boa skill explica o **porquê** de cada regra, lista os gatilhos reais na `description` e não tenta fazer tudo.

**Pendências**
- Nenhuma. Node 24.19 e Angular CLI 20.3.37 instalados.
