# 🐾 Paws Place v2 — Roadmap da reconstrução

> Objetivo: aprender. Back .NET 10 em camadas + front Angular 20, no mesmo padrão do trabalho.
> Este arquivo é só o checklist. Ao concluir uma etapa, o resumo e os principais aprendizados vão para [HISTORICO-V2.md](HISTORICO-V2.md).
> Revise os aprendizados com as suas palavras: se não conseguir explicar, volte nesse ponto antes de seguir.

## Back-end

- [x] **Etapa 0 — Preparação**
  - [x] Branch `v2` a partir do `origin/main`
  - [x] `.gitignore` ajustado, `CLAUDE.md`, este roadmap
  - [x] Node.js LTS + Angular CLI 20 instalados (Node 24.19, CLI 20.3.37)

- [ ] **Etapa 1 — O que é uma API, na prática**
  - Solution + projeto `PawsPlace.Api`, OpenAPI + Scalar
  - Pipeline HTTP, middleware, rotas, verbos, status codes, injeção de dependência
  - Primeiro `GET /api/animais` (lista em memória) testado pelo `.http`

- [ ] **Etapa 2 — Camadas e banco**
  - Projetos Domain, Repository, Service
  - Entidades, `IEntityTypeConfiguration`, primeira migration, seed
  - `IAnimalRepository` / `AnimalRepository` / `AnimalService`, DI por extension methods

- [ ] **Etapa 3 — Animais completo**
  - Listagem paginada com filtros + detalhe por slug
  - Primeiros testes xUnit no service

- [ ] **Etapa 4 — Erros e validação**
  - Exceções de domínio + `IExceptionHandler` + `ProblemDetails`
  - DataAnnotations nos DTOs
  - ➜ Criar a skill `novo-endpoint`

- [ ] **Etapa 5 — Autenticação**
  - Cadastro/login, BCrypt, JWT (segredo em user-secrets), `[Authorize]`, claims

- [ ] **Etapa 6 — Pedidos, Favoritos e Perfil** (você conduz com a skill `novo-endpoint`)

## Front-end

- [ ] **Etapa 7 — Setup Angular 20**
  - `ng new web`, tokens/estilos portados, proxy `/api`, layout, `TemaService`

- [ ] **Etapa 8 — Feature Animais**
  - Models, `AnimaisService` (HttpClient + Observables), filtros com Reactive Forms + `debounceTime`, card, detalhe

- [ ] **Etapa 9 — Auth no front**
  - `AuthService` (`BehaviorSubject`), interceptor, `authGuard`, login/cadastro
  - ➜ Criar a skill `nova-feature-angular`

- [ ] **Etapa 10 — Pedidos, Favoritos e Perfil** (você conduz com a skill `nova-feature-angular`)

## Encerramento

- [ ] **Etapa 11** — remover legado (com confirmação), README v2, retrospectiva

## Mapa vanilla → Angular

| Vanilla (código antigo) | Angular (v2) |
|---|---|
| `scripts/config.js` (`apiFetch`) | `HttpClient` + interceptor + proxy |
| `scripts/auth.js` + `storage.js` | `core/services/auth.service.ts` |
| `scripts/proteger-rota.js` | `core/guards/auth.guard.ts` |
| `scripts/data.js` + `filtros.js` + `render.js` | `features/animais` |
| `scripts/validacao.js` | validators de Reactive Forms |
| `scripts/header.js`, `tema.js` | `shared/layout`, `TemaService` |
