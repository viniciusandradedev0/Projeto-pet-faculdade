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
