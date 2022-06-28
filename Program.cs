LooseCouplingInterface.Console console = new();
LooseCouplingInterface.Diagnostics debug = new();
LooseCouplingInterface.File file = new();

void Log(LooseCouplingInterface.ILogger logger, string message) {
    logger.Log(message);
}

Log(console, "Console message");

Log(debug, "Debug message");

Log(file, "File message");