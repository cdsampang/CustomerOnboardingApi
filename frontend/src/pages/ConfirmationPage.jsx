import CustomerList from "../components/CustomerList";
export default function ConfirmationPage() {
  return (
    <div>
      <h2>Registration Successful!</h2>
      <p>Your customer has been registered.</p>
      <CustomerList />
    </div>
  );
}
