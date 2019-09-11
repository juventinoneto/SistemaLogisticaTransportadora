import { PainelGeralModule } from './painel-geral.module';

describe('PainelGeralModule', () => {
  let painelGeralModule: PainelGeralModule;

  beforeEach(() => {
    painelGeralModule = new PainelGeralModule();
  });

  it('should create an instance', () => {
    expect(painelGeralModule).toBeTruthy();
  });
});
