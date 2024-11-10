import { Form, Input, InputNumber } from 'antd';

const { TextArea } = Input;

const ProductForm = ({ form, isFormDisabled }) => {
    const INT32_MAX = Math.pow(2, 31) - 1;

    return (
        <Form form={form} layout="vertical" className="modal-form">
            <Form.Item hidden name="Id"><InputNumber /></Form.Item>
            <Form.Item name="Name" label="Название товара"
                rules={[
                    {
                        required: true,
                        message: 'Пожалуйста, введите название товара'
                    },
                    {
                        max: 100,
                        message: 'Название товара не должно быть длиннее 100 символов'
                    }]}>
                <TextArea disabled={isFormDisabled} size="large" placeholder="Название товара (100 символов)" count={{ max: 100 }}></TextArea>
            </Form.Item>
            <Form.Item name="Description" label="Описание товара"
                rules={[
                    {
                        required: true,
                        message: 'Пожалуйста, введите описание товара'
                    },
                    {
                        max: 500,
                        message: 'Описание товара не должно быть длиннее 500 символов'
                    }]}>
                <TextArea disabled={isFormDisabled} size="large" placeholder="Описание товара (500 символов)" count={{ max: 500 }}></TextArea>
            </Form.Item>
            <Form.Item name="Vendorcode" label="Код товара"
                rules={[
                    {
                        required: true,
                        message: 'Пожалуйста, укажите количество товара на складе'
                    },
                    {
                        min: 0,
                        type: 'number',
                        message: 'Код товара должен быть положительным числом'
                    },
                    {
                        max: INT32_MAX,
                        type: 'number',
                        message: `Код товара должен быть не больше ${INT32_MAX}`
                    }
                ]}>
                <InputNumber disabled={isFormDisabled} size="large" placeholder="1234567" min="0" />
            </Form.Item>
            <Form.Item name="Quantity" label="Количество на складе"
                rules={[
                    {
                        required: true,
                        message: 'Пожалуйста, укажите количество товара на складе'
                    },
                    {
                        min: 0,
                        type: 'number',
                        message: 'Количество товара должно быть положительным числом'
                    },
                    {
                        max: INT32_MAX,
                        type: 'number',
                        message: `Количество товара должно быть не больше ${INT32_MAX}`
                    }
                ]}>
                <InputNumber disabled={isFormDisabled} id="productQuantity" size="large" placeholder="0" min="0" />
            </Form.Item>
            <Form.Item name="Price" label="Цена товара"
                rules={[
                    {
                        required: true,
                        message: 'Пожалуйста, введите цену товара'
                    },
                    {
                        min: 0,
                        type: 'number',
                        message: 'Цена товара должна быть положительным числом'
                    },
                    {
                        max: INT32_MAX,
                        type: 'number',
                        message: `Цена товара должна быть не больше ${INT32_MAX}`
                    }
                ]}>
                <InputNumber disabled={isFormDisabled} size="large" placeholder="0.00" default={100} step={1} min={0} />
            </Form.Item>
        </Form>
    );
};

export default ProductForm;