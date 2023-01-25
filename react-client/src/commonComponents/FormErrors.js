

const FormErrors = ({formErrors}) => {
    return (
    <div className="formErrors">
        {Object.keys(formErrors).map((fieldName, i) => {
            if(formErrors[fieldName].length > 0) {
                return (
                    <p key={i} className="errorText">{fieldName} {formErrors[fieldName]}</p>
                )
            } else {
                return '';
            }
        })}
    </div>
    )
}


export default FormErrors