import { useState } from "react";
import { createCustomer } from "../services/api";
import SignaturePad from "./SignaturePad";

export default function CustomerForm({ onSuccess }) {
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    email: "",
    phoneNumber: "",
  });

  const [signature, setSignature] = useState("");

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const customerData = { ...formData, signature };
    await createCustomer(customerData);
    onSuccess();
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        name="firstName"
        onChange={handleChange}
        placeholder="First Name"
        required
      />
      <input
        name="lastName"
        onChange={handleChange}
        placeholder="Last Name"
        required
      />
      <input
        name="email"
        onChange={handleChange}
        placeholder="Email"
        type="email"
        required
      />
      <input
        name="phoneNumber"
        onChange={handleChange}
        placeholder="Phone Number"
        required
      />
      <SignaturePad onChange={setSignature} />
      <button type="submit">Create Customer</button>
    </form>
  );
}
