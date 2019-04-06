import { ControleColetaDefinicaoCargaModule } from './controle-coleta-definicao-carga.module';

describe('ControleColetaDefinicaoCargaModule', () => {
  let controleColetaDefinicaoCargaModule: ControleColetaDefinicaoCargaModule;

  beforeEach(() => {
    controleColetaDefinicaoCargaModule = new ControleColetaDefinicaoCargaModule();
  });

  it('should create an instance', () => {
    expect(controleColetaDefinicaoCargaModule).toBeTruthy();
  });
});
