import { JDialogueModule } from './j-dialogue.module';

describe('JDialogueModule', () => {
  let jDialogueModule: JDialogueModule;

  beforeEach(() => {
    jDialogueModule = new JDialogueModule();
  });

  it('should create an instance', () => {
    expect(jDialogueModule).toBeTruthy();
  });
});
