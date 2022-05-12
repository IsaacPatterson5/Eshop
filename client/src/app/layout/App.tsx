import { Container, createTheme, CssBaseline } from "@mui/material";
import { ThemeProvider } from "@mui/system";
import { useState } from "react";
import Catalog from "../../features/catalog/Catalog";
import Header from "./header";

function App() {
  const [darkMode, setDarkMode] = useState(false);
  const paletteType = darkMode ? 'dark' : 'light'
  const theme = createTheme({
    palette: {
      mode: paletteType
    }
  })
  

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline/>
      <Header/>
      <Container>
      <Catalog/>
      </Container>
    </ThemeProvider>
  );
}

export default App;
 