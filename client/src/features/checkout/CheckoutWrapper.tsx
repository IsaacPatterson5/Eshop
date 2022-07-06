import { Elements } from "@stripe/react-stripe-js";
import { loadStripe } from "@stripe/stripe-js";
import CheckoutPage from "./CheckoutPage";

const stripePromise = loadStripe('pk_test_51LIGxhJDYcO9NHFcYT3cazTyRBtNNXoBovgzQn3tX9xvTTfpjificlG9Pgb00WoaAC5ddj9bkurdTTbgOfSs0CL500PCZYMca7')

export default function CheckoutWrapper() {
    return (
        <Elements stripe={stripePromise}>
            <CheckoutPage />
        </Elements>
    )
}