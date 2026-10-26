// ============================================================
// token 0x0600007c   Entrypoint::Load
// native code: 0x28d9581dcd0  (1907 bytes)
// kind: DISPATCH   confidence: high
// original IL signature:
//   .method public hidebysig static
//   void Load () cil managed noinlining
//   
// native-calls: 06000005,0600007f,06000080,06000004,06000081,06000007,06000003,06000082,06000083,06000086,06000087,06000088,06000089,0600008a,06000006,06000084,06000085,0600008b
// native-strings: 0x0:Servers,0xc:ProtonAC,0x18:config.yaml,0x28:translations.yaml,0x8c:Logs,0x58:example_translations.yaml,0x40:example_config.yaml,0x78:ChatGuard,?:D:\\SteamLibrary\\steamapps\\common\\U3DS,?:2803663050144
// ============================================================

// Recovered from native code @0x28d9581dcd0 (1907 bytes incl. state-machine dispatch)
public static void Load()
{
    string root = Path.Combine("D:\\SteamLibrary\\steamapps\\common\\U3DS",
                               "Servers", Provider.serverID, "ProtonAC");
    string configPath       = Path.Combine(root, "config.yaml");
    string translationsPath = Path.Combine(root, "translations.yaml");
    string exampleConfig = null, exampleTranslations = null, logsPath = null;

    if (File.Exists(configPath))
    {
        if (File.Exists(translationsPath))
        {
            File.Delete(translationsPath);
        }
        else
        {
            exampleConfig = Path.Combine(root, "example_config.yaml");
            while (true)
            {
                if (File.Exists(exampleConfig)) { File.Delete(exampleConfig); break; }
                exampleTranslations = Path.Combine(root, "example_translations.yaml");
                if (!File.Exists(exampleTranslations)) break;
                File.Delete(exampleTranslations);
                exampleConfig = Path.Combine(root, "example_config.yaml");
            }
            string chatGuard = Path.Combine(root, "ChatGuard");
            if (Directory.Exists(chatGuard))
                Directory.Delete(chatGuard, true);
        }
        logsPath = Path.Combine(root, "Logs");
    }

    var bootstrapper = _1DB744298E9F4B09._5854F6AC0CF0464E();
    bootstrapper._9127E76D13FB459F(logsPath);     // path/log setup
    bootstrapper._2A06EA6591F2473D(root);          // install root

    if (<>9__1_0 == null)
        <>9__1_0 = new Func<Task>(<>c.<>9, <>c.<Load>b__1_0);

    bootstrapper._287B059A86E24015(<>9__1_0);      // start async bootstrap
    var state = bootstrapper.E8D77ACB56BA43BF();   // init result
    _0ADEE3C50FFE4E94(state);                      // state._2470246CB7CF4D5E()
}
