import { ControleExpedicaoModule } from './controle-expedicao.module';

describe('ControleExpedicaoModule', () => {
  let controleExpedicaoModule: ControleExpedicaoModule;

  beforeEach(() => {
    controleExpedicaoModule = new ControleExpedicaoModule();
  });

  it('should create an instance', () => {
    expect(controleExpedicaoModule).toBeTruthy();
  });
});
