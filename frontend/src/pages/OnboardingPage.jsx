import "../styles/App.css";
import CustomerForm from "../components/CustomerForm";
import CustomerList from "../components/CustomerList";

function OnboardingPage({ onSuccess }) {
  return (
    <div>
      <h2>Customer Onboarding</h2>
      <CustomerForm onSuccess={onSuccess} />
      <CustomerList />
    </div>
  );
}

export default OnboardingPage;
