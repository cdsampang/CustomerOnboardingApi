import { useState } from "react";
import OnboardingPage from "./pages/OnboardingPage";
import ConfirmationPage from "./pages/ConfirmationPage";
import CustomerList from "./components/CustomerList";
import "./styles/App.css";

function App() {
  const [registered, setRegistered] = useState(false);

  return registered ? (
    <>
      <ConfirmationPage />
    </>
  ) : (
    <>
      <OnboardingPage onSuccess={() => setRegistered(true)} />
    </>
  );
}

export default App;
